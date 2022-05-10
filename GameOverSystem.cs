using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverSystem : MonoBehaviour
{
    public void Quit()
    {
        SceneManager.LoadScene("Levels");
    }
}
