using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using Unity.AppUI.UI;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class TimerManager : MonoBehaviour
{
    private float seconds;
    private float minutes;

    public static bool[] firstRecord;
    public static float[] records;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI recordText;

    void Awake()
    {
        records = new float[42];
        firstRecord = new bool[42];
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
        //print("Adding Highscore" + SceneManager.GetActiveScene().buildIndex);
        float newRecord;
        float checkRecord;

        if (firstRecord[level] == false)
        {
            //print("First record" + SceneManager.GetActiveScene().buildIndex);
            firstRecord[level] = true;
            newRecord = seconds + minutes * 60;
            records[level] = newRecord;
        }
        else
        {
            checkRecord = seconds + minutes * 60;

            if (checkRecord < records[level])
            {
                records[level] = checkRecord;
            }
        }
        SetRecordText(SceneManager.GetActiveScene().buildIndex);
    }

    public void SetRecordText(int level)
    {
        //print("Updating Highscore text" + SceneManager.GetActiveScene().buildIndex);
        recordText.text = Mathf.Round(records[level]) + " seconds!";
    }
}
