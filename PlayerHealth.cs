using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private float health = 0f;
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private Slider healthSlider;

    public GameObject GameLoseUI;
    



    private void Start()
    {
        health = maxHealth;
        healthSlider.maxValue = maxHealth;
        

    }

    public void UpdateHealth(float mod)
    {
        health += mod;

        if (health > maxHealth)
        {
            health = maxHealth;
        }
        else if (health <= 0)
        {
            health = 0f;
            //SceneManager.LoadScene("GameLose");
            GameLoseUI.SetActive(true);
            if (GameLoseUI == true)
            {
                Time.timeScale = 0f;
            }
            FindObjectOfType<AudioManager>().Play("Die");
            Debug.Log("Die");

            Debug.Log("I am dead");
        }
    }

    private void OnGUI()
    {
        healthSlider.value = health;
    }
}
