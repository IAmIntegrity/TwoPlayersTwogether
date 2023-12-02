using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Color playerColor;

    private void Start()
    {
        playerColor = GlobalControl.Instance.playerColor; 
    }

    public void SaveManager()
    {
        GlobalControl.Instance.playerColor = playerColor;
    }
}
