using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Game Manager", menuName = "Managers/Game Manager")]
public class GameManagerScriptable : ScriptableObject
{
    public bool isPlaying;

    public ScriptableInteger coin;
    public ScriptableInteger life;

    public GameObject playerPrefab;
    public GameObject playerObject;

    public UnityAction gameOverAction;
    public UnityAction retryAction;

    public void pauseGame() {
        isPlaying = false;
        Time.timeScale = 0;
    }

    public void resumeGame () {
        isPlaying = true;
        Time.timeScale = 1f;
    }

    public void gameOver() {
        isPlaying = false;
        Time.timeScale = 1;
    }

    public void retry () {
        coin.resetValue();
        life.resetValue();
        playerObject = Instantiate(playerPrefab);

        retryAction?.Invoke();

        //isPlaying = true;
    }
}
