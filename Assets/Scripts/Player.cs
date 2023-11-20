using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float movementSpeed = 7f;
    [SerializeField] private float jumpForce = 10f;

    private void Update()
    {
        float inputDirection = 0;

        if (Input.GetKey(KeyCode.A))
        {
            inputDirection = -1f;
        }
        if (Input.GetKey(KeyCode.D)) 
        {
            inputDirection = 1f;
        }
        Vector3 movementDirection = new Vector3((inputDirection * movementSpeed) * Time.deltaTime, 0f, 0f);

        transform.position += movementDirection;
    }
}
