using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagerScript : MonoBehaviour
{

    private void Start()
    {
        Time.timeScale = 1;
    }
    public void DelayStartMenu()
    {
        Invoke("GoToMenuScene", 2f);
    }

    public void DelayStartEasy()
    {
        Invoke("GoToEasyScene", 2f);
    }

    public void DelayStartHard()
    {
        Invoke("GoToHardScene", 2f);
    }
    public void GoToMenuScene()
    {
        SceneManager.LoadScene("Scenes/Menu");
    }

    public void GoToEasyScene()
    {
        SceneManager.LoadScene("Scenes/Easy");
    }

    public void GoToHardScene()
    {
        SceneManager.LoadScene("Scenes/Hard");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
