using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    private GameObject gameM;
    private GameManager gameManager;

    void Start()
    {
        gameM = GameObject.Find("GameManager");
        gameManager = gameM.GetComponent<GameManager>();
    }

    public void StartPlaying()
    {
        Time.timeScale = 1;
        gameManager.gamePaused = false;
        SceneManager.LoadScene(LevelManager.currentMaxLevel);
    }

    public void SelectLevel()
    {
        SceneManager.LoadScene("Level Select");
    }

    public void Continue()
    {
        Time.timeScale = 1;
        gameManager.gamePaused = false;
    }

    public void Restart()
    {
        Time.timeScale = 1;
        gameManager.gamePaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Settings()
    {
        print("Whomp Whomp");
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        gameManager.gamePaused = false;
        SceneManager.LoadScene("Main Menu");
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
