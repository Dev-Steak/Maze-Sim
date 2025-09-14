using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    private GameObject MenuUI;

    void Start()
    {
        MenuUI = GameObject.Find("MenuUI");
    }

    public void Continue()
    {
        Time.timeScale = 1.0f;
        MenuUI.SetActive(false);
    }

    public void Restart()
    {
        Time.timeScale = 1.0f;
        MenuUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().ToString());
    }

    public void Settings()
    {
        print("Whomp Whomp");
    }

    public void MainMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Main Menu");
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
