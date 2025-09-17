using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using Unity.AppUI.UI;
using Unity.VisualScripting;

public class TimerManager : MonoBehaviour
{
    private float seconds;
    private float minutes;
    [SerializeField] public static float[] records;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI recordText;

    void Awake()
    {
        records = new float[40];
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

    public void AddHighscore(int level)
    {
        float newRecord;
        newRecord = seconds + minutes * 60;

        if (records[level] == 0)
        {
            records[level] = newRecord;
        }
        else if (newRecord < records[level])
        {
            records[level] = newRecord;
        }
    }

    public void SetRecordText(int level)
    {
        recordText.text = Mathf.Round(records[level]) + " seconds!";
    }
}
