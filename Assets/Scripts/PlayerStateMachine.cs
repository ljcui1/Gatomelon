using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KevinCastejon.FiniteStateMachine;
public class PlayerStateMachine : AbstractFiniteStateMachine
{
    public PlayerManager Manager { get; set; }
    public enum PlayerFSM
    {
        IDLE,
        WALK,
        JUMP
    }
    private void Awake()
    {
        Init(PlayerFSM.IDLE,
            AbstractState.Create<IdleState, PlayerFSM>(PlayerFSM.IDLE, this),
            AbstractState.Create<WalkState, PlayerFSM>(PlayerFSM.WALK, this),
            AbstractState.Create<JumpState, PlayerFSM>(PlayerFSM.JUMP, this)
        );

        Manager = transform.GetComponent<PlayerManager>();
    }
    public class IdleState : AbstractState
    {
        public override void OnEnter()
        {
            //GetStateMachine<PlayerStateMachine>().Manager.StartIdle();
        }
        public override void OnUpdate()
        {
            // if(GetStateMachine<PlayerStateMachine>().Manager.walking) {
            //      TransitionToState(PlayerFSM.WALK);
            // }
        }
        public override void OnExit()
        {
        }
    }
    public class WalkState : AbstractState
    {
        public override void OnEnter()
        {
        }
        public override void OnUpdate()
        {
        }
        public override void OnExit()
        {
        }
    }
    public class JumpState : AbstractState
    {
        public override void OnEnter()
        {
        }
        public override void OnUpdate()
        {
        }
        public override void OnExit()
        {
        }
    }
}
