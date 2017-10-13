using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {

    public float speed;
    public float forwardForce;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

        if (true)
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        float moveHorizontal = Input.GetAxis("Horizontal");
       //float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f);

        rb.AddForce(movement * speed);
    }
}
