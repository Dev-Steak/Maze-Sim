using UnityEngine;
using System.Collections;
using UnityEditorInternal;
using TMPro;

public class GameManager : MonoBehaviour
{
    private static int currentMaxLevel;

    private float seconds;
    private float minutes;

    public bool unplayableLevel;

    [SerializeField] private TextMeshProUGUI timerText;

    private GameObject entrance;
    private GameObject player;
    private GameObject MenuUI;

    void Start()
    {
        entrance = GameObject.Find("Entrance");
        player = GameObject.Find("Player");
        MenuUI = GameObject.Find("MenuUI");

        Time.timeScale = 1.0f;

        MenuUI.SetActive(false);
        player.transform.position = new Vector2(entrance.transform.position.x, entrance.transform.position.y - 1);
    }
    void Update()
    {
        if (unplayableLevel == false)
        {
            Timer();

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 0.0f;
                MenuUI.SetActive(true);
            }
        }        
    }
    
    public void Timer()
    {
        seconds += Time.deltaTime;
        if (seconds < 10)
        {
            timerText.text = "- 0" + (int)minutes + " : 0" + (int)seconds + " -";
        }
        else if (seconds < 60 && seconds >= 10)
        {
            timerText.text = "- 0" + (int)minutes + " : " + (int)seconds + " -";
        }

        if (seconds >= 60)
        {
            seconds = 0;
            minutes++;
        }
    }
}
