using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    public static bool GameIsPaused = true;

    public GameObject pauseMenuUI;

    private void Start()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    void StartGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Button()
    {
        StartGame();
    }
}
