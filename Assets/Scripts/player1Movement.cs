using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player1Movement : MonoBehaviour
{

    public float moveSpeed;
    public float jumpForce;
    public Rigidbody2D rb;

    public KeyCode left1;
    public KeyCode right1;
    public KeyCode jump1;

    private int count;
    public bool isGrounded1;

    Animator anim;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        anim.SetInteger("state", 1);

        if (Input.GetKey(left1))
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }
        else if (Input.GetKey(right1))
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }


        if (rb.transform.position.y < 0 && !isGrounded1)
        {
            isGrounded1 = true;
            anim.SetInteger("state", 1);
        }

        else if (rb.transform.position.y > 0)
        {
            isGrounded1 = false;
            anim.SetInteger("state", 2);
        }

        if (Input.GetKeyDown(jump1) && isGrounded1)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            anim.SetInteger("state", 2);
        }

        if (Input.GetKey(left1) && isGrounded1 || Input.GetKey(right1) && isGrounded1)
        {
            anim.SetInteger("state", 3);
        }

        if (Input.GetKey(left1) && !isGrounded1 || Input.GetKey(right1) && !isGrounded1)
        {
            anim.SetInteger("state", 4);
        }


    }



}
