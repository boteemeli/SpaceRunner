using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rb;
    float horizontalInput;
    public float horizontalMultiplier = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void FixedUpdate()
    {
        Vector3 forwardmove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardmove + horizontalMove);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }
}
