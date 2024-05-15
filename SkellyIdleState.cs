using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkellyIdleState : EnemyState
{
    Enemy_Skeleton enemy;
    // Start is called before the first frame update
    public SkellyIdleState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBoolName, Enemy_Skeleton _enemy) : base(_enemy, _stateMachine, _animBoolName)
    {
        enemy = _enemy;
    }

    public override void Enter()
    {
        base.Enter();

        stateTimer = enemy.idelTime;
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        if (stateTimer < 0) {
            stateMachine.ChangeState(enemy.moveState);
        }
    }
}
