using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float speed = 10f;
    public float jumpSpeed = 10f;
    public float distToGround = 0.5f;
    Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   
    void FixedUpdate()
    {
        //Debug.Log (isGrounded()); 

        if (Input.GetKey(KeyCode.PageUp)&& isGrounded())
        {
            //rb.AddForce(0, 11f, 0);
            Vector3 jumpVelocity = new Vector3(0f, jumpSpeed, 0f);
            rb.velocity = rb.velocity + jumpVelocity;
        }
        
    }

    bool isGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, distToGround);
    }
}
