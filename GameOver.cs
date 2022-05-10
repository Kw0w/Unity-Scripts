using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverUi;
    public GameObject bragUi;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
           GameOverUi.SetActive(true);
            bragUi.SetActive(false);
            Time.timeScale = 0f;
            FindObjectOfType<AudioManager>().Play("Over");
            Debug.Log("Step");
            
            Debug.Log("GameOver sara?");
        }
    }
}
