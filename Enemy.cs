using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 0.5f;
    [SerializeField] private float attackDamage = 10f;
    [SerializeField] private float attackSpeed = 1f;
    private float canAttack;

    public GameObject bloodEffect;

    private Transform target;

    private void Update()
    {
        if (target != null)
        {
          float step = speed * Time.deltaTime;
          transform.position = Vector2.MoveTowards(transform.position, target.position, step);
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if (attackSpeed <= canAttack)
            {
                other.gameObject.GetComponent<PlayerHealth>().UpdateHealth(-attackDamage);
                // Need to be health bar decrese
                

                Debug.Log("Are you dead yet?");
                FindObjectOfType<AudioManager>().Play("Uh");
                Debug.Log("Uh");
                Instantiate(bloodEffect, transform.position, Quaternion.identity);
                canAttack = 0f;
            }else
            {
                canAttack += Time.deltaTime;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            target = other.transform;
            Debug.Log("BargO");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            target = null;
            Debug.Log("Bark");
        }
    }
}
