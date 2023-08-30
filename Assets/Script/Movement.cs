using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;

    Animator animator;

    [SerializeField] float speed = 70f; // toc chay

    [SerializeField] float jumpForce = 20f;

    bool IsOnGround = true;

    CircleCollider2D thisCollision;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        thisCollision = GetComponent<CircleCollider2D>();
        rb.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = UnityEngine.Input.GetAxisRaw("Horizontal");
        //Debug.Log(xInput);
        Move(xInput);
        FlipFace();
        Jump();
    }
    void Move(float _xInput)
    {
        bool IsMove = rb.velocity.x != 0;
        rb.velocity = new Vector2(_xInput * speed, rb.velocity.y);
        if (rb.velocity != null)
        {
            animator.SetBool("IsRunning", IsMove);
        }

    }
    void FlipFace()
    {
        bool IsMove = rb.velocity.x != 0;
        if (IsMove)
        {
            transform.localScale = new Vector3(-Mathf.Sign(rb.velocity.x), transform.localScale.y);
        }
    }

    void Jump()
    {
        if (UnityEngine.Input.GetKeyDown(KeyCode.Space) && thisCollision.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            //Debug.Log("jump");
            rb.AddForce(new Vector2(0, jumpForce));
            animator.SetBool("IsJump", true);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("Jump", false);
        }
    }

}


