using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private GameObject gameManager;
    private TimerManager timerManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        timerManager = gameManager.GetComponent<TimerManager>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        timerManager.AddHighscore(SceneManager.GetActiveScene().buildIndex);
        timerManager.SetRecordText(SceneManager.GetActiveScene().buildIndex);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        LevelManager.currentMaxLevel++;
    }
}
