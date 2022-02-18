using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool isGrounded = false;
    bool facingRight = true;

 

    public Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    void Update()
    {
       
        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
        if (movement != Vector3.zero)
        {

            animator.SetBool("isWalking", true);
            
            transform.position += movement * Time.deltaTime * moveSpeed;

            if (Input.GetAxisRaw("Horizontal") < 0 && facingRight)
            {
                facingRight = !facingRight; //if facing right is true it will be false and if it is false it will be true
                transform.Rotate(0, 180, 0);
            }
            else if (Input.GetAxisRaw("Horizontal") > 0 && !facingRight)
            {
                facingRight = !facingRight;
                transform.Rotate(0, 180, 0);
            }           
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        Jump();

        
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            animator.SetTrigger("isJumping");
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 6f), ForceMode2D.Impulse);

            
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            isGrounded = true;
            animator.SetBool("isGrounded", true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground")
        {
            isGrounded = false;
            animator.SetBool("isGrounded", false);
        }
    }
}
