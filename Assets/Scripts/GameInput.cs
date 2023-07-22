using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour {
    public event EventHandler OnJumpAction;
    private PlayerInput playerInput;

    private void Awake() {
        playerInput = new PlayerInput();
        playerInput.Player.Enable();

        playerInput.Player.Jump.performed += Jump_performed;
    }

    private void Jump_performed(InputAction.CallbackContext obj) {
       OnJumpAction?.Invoke(this, EventArgs.Empty);
    }

    public Vector2 GetNormalizedMovementVector() {
        Vector2 inputVector = playerInput.Player.Move.ReadValue<Vector2>();

        return inputVector.normalized;
    }
}
