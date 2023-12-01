using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerMovement PM;

    private void Update()
    {
        DetectMovement();
    }

    private void DetectMovement()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            PM.PlayerMove();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PM.PlayerJump();
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            PM.PlayerRun();
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            PM.PlayerWalk();
        }
    }
}
