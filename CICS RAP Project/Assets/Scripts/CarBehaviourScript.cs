using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBehaviourScript : MonoBehaviour
{

    public Rigidbody2D rb;
    public float turnSpeed = 5;
    public int speed = 6;
    private float moveY;
    private float turnX;
    private float spin;
    private float fVelocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveY = Input.GetAxis("Vertical");
        turnX = Input.GetAxis("Horizontal");
        spin = turnX * -turnSpeed;
    }

    private void FixedUpdate()
    {
        fVelocity = transform.InverseTransformDirection(rb.velocity).y;

        if (fVelocity > 0.1)
        {
            //transform.Rotate(Vector3.forward, spin);
            rb.AddTorque(-turnX * turnSpeed);
        }
        
        rb.velocity = transform.up * (moveY * speed);

        /*
         * THIS SORTA WORKS IN A WAY, if we move foward with velocity insteam then just delete this pls
        rb.AddForce(transform.up * (moveY * speed));
        */

    }
}
