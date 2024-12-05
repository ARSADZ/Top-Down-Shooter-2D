using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenuUI : MonoBehaviour
{
    public GameManagerScriptable gameManager;
    public InputHandler inputHandler;

    public GameObject menuContainer;

    public GameObject startMenu;
    public GameObject pauseMenu;
    public GameObject gameOverMenu;

    void Start()
    {
        showStartMenu();
    }

    public void startGame() {
        gameManager.isPlaying = true;
    }

    public void showPauseMenu() {
        menuContainer.SetActive(true);

        startMenu.SetActive(false);
        pauseMenu.SetActive(true);
        gameOverMenu.SetActive(false);
    }
    
    public void showStartMenu() {
        menuContainer.SetActive(true);

        startMenu.SetActive(true);
        pauseMenu.SetActive(false);
        gameOverMenu.SetActive(false);
    }
    
    public void showGameOver() {
        menuContainer.SetActive(true);

        startMenu.SetActive(false);
        pauseMenu.SetActive(false);
        gameOverMenu.SetActive(true);
    }

    public void hideMenu() {
        menuContainer.SetActive(false);

        inputHandler.enableGameplay();
        gameManager.resumeGame();
    }

    private void OnApplicationQuit() {
        gameManager.isPlaying = false;
    }

    private void OnEnable() {
        inputHandler.actionShowMenu += OnShowMenu;
        gameManager.gameOverAction += showGameOver;
    }

    private void OnDisable() {
        inputHandler.actionShowMenu -= OnShowMenu;
        gameManager.gameOverAction -= showGameOver;
    }

    private void OnShowMenu() {
        if (gameManager.isPlaying) {
            showPauseMenu();
            gameManager.pauseGame();
        } else {
            hideMenu();
            gameManager.resumeGame();
        }
    }

    public void retry () {
        showStartMenu();
        gameManager.retry();
    }

    public void quit() {
        Application.Quit();
    }
}
