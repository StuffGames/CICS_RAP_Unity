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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveY = Input.GetAxis("Vertical");
        turnX = Input.GetAxis("Horizontal");
        rb.velocity = transform.up * (moveY * speed);
        spin = turnX * -turnSpeed;
    }

    private void FixedUpdate()
    {
        if (rb.velocity.x != 0 || rb.velocity.y != 0)
        {
            transform.Rotate(Vector3.forward, spin);
        } 
    }
}
