using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;

    Animator animator;

    [SerializeField] float speed = 70f;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        rb.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = UnityEngine.Input.GetAxisRaw("Horizontal");
        Debug.Log(xInput);
        Move(xInput);
        FlipFace();
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

}
