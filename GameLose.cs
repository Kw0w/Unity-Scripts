using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLose : MonoBehaviour
{
   public void playAgain0()
    {
        SceneManager.LoadScene("Levels");
    }
    
    public void leave()
    {
       SceneManager.LoadScene("MainMenu");
    }
}
