using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateController : MonoBehaviour
{
    public GameManagerScriptable gameManager;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void gameOver() {
        gameManager.gameOver();
        gameManager.gameOverAction?.Invoke();
    }
}
