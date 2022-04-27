using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GIMovementSystem
{
    public class PlayerInput : MonoBehaviour
    {
        public PlayerInputActions InputActions {get; private set; }
        public PlayerInputActions.PlayerActions PlayerActions { get; private set; }

        void Awake()
        {
            InputActions = new PlayerInputActions();

            PlayerActions = InputActions.Player;
        }

        void OnEnable()
        {
            InputActions.Enable();
        }

        void OnDisable()
        {
            InputActions.Disable();
        }
    }
}
