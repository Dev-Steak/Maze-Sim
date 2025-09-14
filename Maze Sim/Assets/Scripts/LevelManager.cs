using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] public static int currentMaxLevel;

    void Awake()
    {
        currentMaxLevel = 2;
    }

    public void PlayLevel(int level)
    {
        if (currentMaxLevel < level + 1)
        {
            print("Didnt unlock level yet");
        }
        else
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(level + 1);
        }
    }
}
