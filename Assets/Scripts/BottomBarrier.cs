using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomBarrier : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.transform.position = Vector3.zero;
    }
}
