using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using StateMachine.Base;
using StateMachine.Enemy.State;
using Core;
using System;

public class FieryMonoStateMachine : StateMachineHandler<FieryMachineData, FieryMachineFunctions>
{

    private NavMeshAgent _agent;
    private Animator _animator;
    private DetectCollider _detectCollider;
    private AttackCollider _attackCollider;
    private AnimationEvents _animationEvents;
    private HpBar _hpComponent;
    public NavMeshAgent Agent => _agent ? _agent : _agent = GetComponent<NavMeshAgent>();
    public Animator Animator => _animator ? _animator : _animator = GetComponentInChildren<Animator>();
    public DetectCollider DetectCollider => _detectCollider ? _detectCollider : _detectCollider = GetComponentInChildren<DetectCollider>();
    public AttackCollider AttackCollider => _attackCollider ? _attackCollider : _attackCollider = GetComponentInChildren<AttackCollider>();
    public AnimationEvents AnimationEvents => _animationEvents ? _animationEvents : _animationEvents = GetComponentInChildren<AnimationEvents>();
    public HpBar HpComponent => _hpComponent ? _hpComponent : _hpComponent = GetComponent<HpBar>();
    public bool PlayerWithinDetectRange => DetectCollider.ObjectWithinDetectRange;
    public bool PlayerWithinAttackRange => AttackCollider.ObjectWithinAttackRange;

    public Transform CurrentTarget;
    public Renderer[] MainRenderers;


    public Action OnEndState;

    bool CanChangeState = true;
    public override void Awake()
    {
        base.Awake();
    }
    public override void Update()
    {
        CurrentState.StateUpdate();
    }
    public override void FixedUpdate()
    {
        CurrentState.StateFixedUpdate();
    }
    public override void SetState(FieryMachineData newState)
    {
        if (newState == null || !newState.IsUnlocked || !CanChangeState)
            return;

        CurrentState?.Discard();
        CurrentState = newState.Initialize(this);
        CanChangeState = newState.CanChangeState;
    }

    public void LookAtTarget() => transform.rotation = Quaternion.LookRotation(CurrentTarget.position - transform.position);
    
    public void DestroyGameobject() => Destroy(gameObject);

}

