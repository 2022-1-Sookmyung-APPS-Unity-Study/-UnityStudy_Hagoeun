using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    Rigidbody2D rb;
    Animator anim;

    public int health;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
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

        rb.velocity = new Vector2(input * speed, rb.velocity.y);
    }


    public void TakeDamage(int damageAmount) {
        health -= damageAmount;

        if (health <= 0) {
            // Destroy player
            Destroy(gameObject);
        }
    }
}
