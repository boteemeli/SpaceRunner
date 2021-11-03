using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    bool alive = true;
    private float speed = 4.0f;
    private double idk = 4.0;
    public Rigidbody rb;
    float horizontalInput;
    public float horizontalMultiplier = 2;
    public float upwardMultiplier = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void FixedUpdate()
    {
        if (!alive) return;

        IncreasingSpeed();
        Vector3 forwardmove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        Vector3 up = transform.up * Time.fixedDeltaTime * speed * 0;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            up = transform.up * Time.fixedDeltaTime * speed * upwardMultiplier;
        }
        rb.MovePosition(rb.position + forwardmove + horizontalMove + up);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (transform.position.y < -5)
        {
            Die();
        }
    }
    public void Die()
    {
        alive = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void IncreasingSpeed()
    {
        idk = idk + 0.01;
        speed = (float)idk;
    }
}
