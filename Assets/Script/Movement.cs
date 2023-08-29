using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        //float xInput = Input.GetAxisRaw("Horizontal");
        //transform.DOMoveX(12, 2f).SetLoops(-1, LoopType.Yoyo);
        rb = GetComponent<Rigidbody2D>();
        transform.Translate(10f * Time.deltaTime, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // float xInput = Input.GetAxisRaw("Horizontal");
        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //transform.Translate(xInput * 10f * Time.deltaTime, 0, 0);
        }
    }
}
