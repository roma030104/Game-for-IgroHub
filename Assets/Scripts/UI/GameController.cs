using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameController : MonoBehaviour
{
    public GameObject gameOverUI;

    public void gameOver() 
    {
        gameOverUI.SetActive(true);
    }
}
