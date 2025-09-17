using UnityEngine;
using System.Collections;
using UnityEditorInternal;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static int currentMaxLevel;

    public bool unplayableLevel;
    public bool gamePaused;

    private GameObject entrance;
    private GameObject player;
    private GameObject MenuUI;

    private TimerManager timerManager;

    void Start()
    {
        entrance = GameObject.Find("Entrance");
        player = GameObject.Find("Player");
        MenuUI = GameObject.Find("MenuUI");

        timerManager = gameObject.GetComponent<TimerManager>();

        Time.timeScale = 1;
        gamePaused = false;

        if (unplayableLevel == false)
        {
            MenuUI.SetActive(false);
            player.transform.position = new Vector2(entrance.transform.position.x, entrance.transform.position.y - 1);
        }
    }
    void Update()
    {
        if (unplayableLevel == false && gamePaused == false)
        {
            MenuUI.SetActive(false);
            timerManager.Timer();
        }

        if (unplayableLevel == false && gamePaused == true)
        {
            MenuUI.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            gamePaused = true;
        }

        timerManager.SetRecordText(SceneManager.GetActiveScene().buildIndex);  
    }
}
