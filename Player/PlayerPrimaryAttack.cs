using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrimaryAttack : PlayerState
{

    private int comboCounter;
    private float lastTimeAttacked;
    private float comboWindow = 2;
    public PlayerPrimaryAttack(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();

        if ( comboCounter > 2 || Time.time >= lastTimeAttacked + comboWindow )
        {
            comboCounter = 0;
        }

        player.anim.SetInteger("comboCounter", comboCounter);
        Debug.Log(comboCounter);

        stateTimer = .1f;
    }

    public override void Exit()
    {
        base.Exit();

        comboCounter++;
        lastTimeAttacked = Time.time;
        Debug.Log(lastTimeAttacked);    
    }

    public override void Update()
    {
        base.Update();

        if(stateTimer < 0)
        rb.velocity = new Vector2(0,0);

        if(triggerCalled)
        {
            stateMachine.ChangeState(player.idleState);
        }
    }
}
