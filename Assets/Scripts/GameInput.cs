using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour {

    private PlayerInputActions playerInputActions;

    private void Awake() {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
    }

    public Vector2 GetNormalizedMovmentVector() {
        Vector2 inputVector = playerInputActions.Player.Movement.ReadValue<Vector2>();

        Debug.Log(inputVector);

        return inputVector.normalized;
    }
}
