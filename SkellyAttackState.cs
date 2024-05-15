using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkellyAttackState : EnemyState
{

    public bool Attack;
    // Start is called before the first frame update
    public SkellyAttackState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBoolName) : base(_enemyBase, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();

        if (isPlayerDetected())
        {
            // Player detected, trigger attack animation
            enemyBase.anim.SetTrigger("Attack");
            Debug.Log("enemy spotted");
            // You can add additional logic here for attacking the player
        }

    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
    }
}
