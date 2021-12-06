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
    float verticalInput;
    float jumpSpeed = 10.0f;
    public float horizontalMultiplier = 1;
    public GameObject ScoreAmount;
    public int ToSaveTheScore;


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
        Vector3 verticalMove = transform.up * verticalInput * jumpSpeed * Time.fixedDeltaTime;

        rb.MovePosition(rb.position + forwardmove + horizontalMove);
        rb.MovePosition(rb.position + verticalMove);

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        if (transform.position.y < -2)
        {
            Die();
        }
    }
    public void Die()
    {
        alive = false;
        ScoreSaving();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ScoreSaving()
    {
        PlayerPrefs.SetInt("score", ToSaveTheScore);
        PlayerPrefs.Save();
    }
    public void IncreasingSpeed()
    {
        idk = idk + 0.01;
        speed = (float)idk;
    }
}
