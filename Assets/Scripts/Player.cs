using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    // Start is called before the first frame update
    [SerializeField] private GameInput gameInput;
    [SerializeField] private float JUMP_HEIGHT = 50f;
    [SerializeField] private float MOVEMENT_SPEED = 7f;
    [SerializeField] private Rigidbody playerBody;

    private void Start() {
        gameInput.OnJumpAction += GameInput_OnJumpAction; 
    }

    private void GameInput_OnJumpAction(object sender, System.EventArgs e) {
        playerBody.AddForce(Vector3.up * JUMP_HEIGHT);
    }

    // Update is called once per frame
    private void Update() {
        HandleMovement();

    }



    private void HandleMovement() {
        Vector2 inputVector = gameInput.GetNormalizedMovementVector();
        Vector3 movementVector = new Vector3(inputVector.x, 0f, inputVector.y);

        transform.position += movementVector * Time.deltaTime * MOVEMENT_SPEED;
    }
}
