using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public int jumpForce = 5;
    public Transform raycastOrigin;
    public bool isGrounded;
    public float raycastDistance = 0.1f;  // Distance to check for ground
    bool jump;
    public Animator anim;
    float lastYPos;
    public float distanceFrom;

    private void Start()
    {
        lastYPos = transform.position.y;
    }
    void Update()
    {
        distanceFrom += Time.deltaTime; 
        CheckForInput();
        PlayFallingAnim();
    }
    void FixedUpdate()
    {
        CheckForGround();
        JumpBool();

    }
    void JumpBool()
    {
        if (jump == true)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            jump = false;
        }
    }
    void PlayFallingAnim()
    {
        if(transform.position.y < lastYPos)
        {
            anim.SetBool("Falling", true);
        }
        else
        {
            anim.SetBool("Falling", false);
        }

        lastYPos = transform.position.y;        
    }

    void CheckForInput()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            jump = true;
            anim.SetTrigger("Jump");
        }
    }
    void CheckForGround()
    {
        RaycastHit2D hit = Physics2D.Raycast(raycastOrigin.position, Vector2.down);

        if (hit.collider != null)
        {
            if (hit.distance < 0.1f)
            {
                isGrounded = true;
                anim.SetBool("IsGrounded", true);
            }
            else
            {
                isGrounded = false;
                anim.SetBool("IsGrounded", false);
            }
        
        }
        Debug.DrawRay(raycastOrigin.position, Vector2.down * raycastDistance, Color.green);
    }
}
