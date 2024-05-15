using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Skeleton : Enemy
{

    #region states

    public SkellyIdleState idleState {  get; private set; }
    public SkellyMoveState moveState { get; private set; }

    #endregion
    protected override void Awake()
    {
        base.Awake();

        idleState = new SkellyIdleState(this, stateMachine, "Idle", this);
        moveState = new SkellyMoveState(this, stateMachine, "Move", this);

    }

    protected override void Start()
    {
        base.Start();
        stateMachine.Initialize(idleState);
    }

    protected override void Update()
    {
        base.Update();
    }
}
