using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRb;
    [SerializeField] private float playerMovementSpeed;
    [SerializeField] private float playerWalkSpeed = 7f;
    [SerializeField] private float playerRunSpeed = 10f;
    [SerializeField] private float playerJumpForce = 25f;
    [SerializeField] private bool isGrounded;

    private void Start()
    {
        playerMovementSpeed = playerWalkSpeed;
    }

    public void PlayerMove()
    {
        float inputDirection = Input.GetAxisRaw("Horizontal");

        Vector3 movementDirection = new Vector3((inputDirection * playerMovementSpeed) * Time.deltaTime, 0f, 0f);

        transform.position += movementDirection;
    }

    public void PlayerRun()
    {
        playerMovementSpeed = playerRunSpeed;
    }
    public void PlayerWalk()
    {
        playerMovementSpeed = playerWalkSpeed;
    }

    public void PlayerJump()
    {
        Vector3 jump = new Vector3(0, playerJumpForce * 10, 0);

        playerRb.AddForce(jump);
    }
}
