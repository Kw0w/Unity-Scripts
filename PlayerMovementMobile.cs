using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementMobile : MonoBehaviour
{

    public float moveSpeed = 5f;
    float horiozntalMove = 0f;

    public Rigidbody2D rb;
    public Animator animator;
    public Joystick joystick;
    private bool isDashButtonDown;

    public GameObject dashEffect;
    


    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //Movement
         
        movement.x = joystick.Horizontal * moveSpeed;
        Debug.Log("move");
        movement.y = joystick.Vertical * moveSpeed;
        Debug.Log("move");

        /*movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        */
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
       
        //Dash
        if (Input.GetButtonDown("Dash"))
        {
            isDashButtonDown = true;
            Instantiate(dashEffect, transform.position, Quaternion.identity);
            FindObjectOfType<AudioManager>().Play("Dash");
            Debug.Log("Dash");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isDashButtonDown = true;
            Instantiate(dashEffect, transform.position, Quaternion.identity);
            FindObjectOfType<AudioManager>().Play("Dash");
            Debug.Log("Dash");
        }
       
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        //Dash
        if (isDashButtonDown)
        {
            float dashAmount = 0.5f;
            rb.MovePosition(rb.position + movement * dashAmount);
            
            isDashButtonDown = false;
        }
    }

}
