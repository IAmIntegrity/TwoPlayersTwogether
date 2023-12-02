using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomiseMenu : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private Image playerColorViewer;

    public void RedButton()
    {
        gameManager.playerColor = Color.red;
        playerColorViewer.color = gameManager.playerColor;
    }
    public void GreenButton()
    {
        gameManager.playerColor = Color.green;
        playerColorViewer.color = gameManager.playerColor;
    }
    public void BlueButton()
    {
        gameManager.playerColor = Color.blue;
        playerColorViewer.color = gameManager.playerColor;
    }
}