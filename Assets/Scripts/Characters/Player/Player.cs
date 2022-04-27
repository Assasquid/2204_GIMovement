using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GIMovementSystem
{
    [RequireComponent(typeof(PlayerInput))]
    public class Player : MonoBehaviour
    {
        public Rigidbody Rigidbody { get; private set; }
        public PlayerInput Input { get; private set; }

        PlayerMovementStateMachine movementStateMachine;

        void Awake()
        {
            Input = GetComponent<PlayerInput>();

            Rigidbody = GetComponent<Rigidbody>();

            movementStateMachine = new PlayerMovementStateMachine(this);
        }

        void Start()
        {
            movementStateMachine.ChangeState(movementStateMachine.IdlingState);
        }

        void Update()
        {
            movementStateMachine.HandleInput();

            movementStateMachine.Update();
        }

        void FixedUpdate() 
        {
            movementStateMachine.PhysicsUpdate();
        }
    }
}
