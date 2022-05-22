using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject losePanel;

    public Text healthDisplay;

    public float speed;

    Rigidbody2D rb;
    Animator anim;
    AudioSource source;

    public int health;

    public float startDashTime;
    private float dashTime;
    public float extraSpeed;
    private bool isDashing;

    void Start()
    {
        source = GetComponent<AudioSource>(); 
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        healthDisplay.text = health.ToString();
    }

    void FixedUpdate()
    {
        float input = Input.GetAxisRaw("Horizontal");

        if (input != 0)
        {
            anim.SetBool("isRunning", true);
        }
        else { 
            anim.SetBool("isRunning", false);
        }

        if (input > 0) {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (input < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isDashing == false)
        {
            speed += extraSpeed;
            isDashing = true;
            dashTime = startDashTime;
        }

        if (dashTime <= 0 && isDashing == true)
        {
            isDashing = false;
            speed -= extraSpeed;
        }

        else {
            dashTime -= Time.deltaTime;
        
        }

        rb.velocity = new Vector2(input * speed, rb.velocity.y);
    }


    public void TakeDamage(int damageAmount) {
        source.Play();
        health -= damageAmount;
        healthDisplay.text = health.ToString();

        if (health <= 0) {
            // Destroy player
            losePanel.SetActive(true);
            Destroy(gameObject);
        }
    }
}
