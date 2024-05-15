using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    [Header("Move Info")]
    public float moveSpeed;
    public float idelTime;

    [Header("Detection")]
    [SerializeField] protected Transform playerCheck;
    [SerializeField] protected float playerCheckDistance;
    [SerializeField] protected LayerMask whatIsPlayer;



    public EnemyStateMachine stateMachine { get; private set; }

    protected override void Awake()
    {
            base.Awake();
            stateMachine = new EnemyStateMachine();
           
    }

    public virtual bool isPlayerDetected() => Physics2D.Raycast(playerCheck.position, Vector2.right * facingDir, playerCheckDistance, whatIsPlayer);

    protected virtual void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(playerCheck.position, new Vector3(playerCheck.position.x + playerCheckDistance, playerCheck.position.y));
    }
    protected override void Update()
    {
        base.Update();
        stateMachine.currentState.Update();
    }
}
