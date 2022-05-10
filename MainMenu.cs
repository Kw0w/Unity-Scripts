using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

   
    public void Play()
    {
        SceneManager.LoadScene("game");
    }

    public void ExitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void PlayHard()
    {
        SceneManager.LoadScene("hard");
    }

    public void PlayTrve()
    {
        SceneManager.LoadScene("trve");
    }

    public void OpenUrl()
    {
        Application.OpenURL("https://kw0w.github.io/");
        Debug.Log("Link");
    }
}
