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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveY = Input.GetAxis("Vertical");
        turnX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(rb.velocity.x, moveY * speed);
        transform.Rotate(Vector3.forward, turnX * turnSpeed);
    }

    private void FixedUpdate()
    {
        
    }
}
