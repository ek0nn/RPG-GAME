using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class SkellyMoveState : EnemyState
{
    private Enemy_Skeleton enemy;
    public SkellyMoveState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBoolName, Enemy_Skeleton _enemy) : base(_enemyBase, _stateMachine, _animBoolName)
    {// _ is the value that has been passed 
        this.enemy = _enemy;
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        enemy.SetVelocity(enemy.moveSpeed * enemy.facingDir, enemy.rb.velocity.y);

        if(enemy.IsWallDetected() || !enemy.IsGroundDetected())
        {
           enemy.Flip();
            stateMachine.ChangeState(enemy.idleState);
        }
    }
}
