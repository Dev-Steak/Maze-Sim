using UnityEngine;
using System.Collections;
using UnityEditorInternal;
using TMPro;

public class GameManager : MonoBehaviour
{
    private float seconds;
    private float minutes;

    public bool unplayableLevel;

    [SerializeField] private TextMeshProUGUI timerText;
    void Update()
    {
        if (unplayableLevel == false)
        {
            Timer();
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
