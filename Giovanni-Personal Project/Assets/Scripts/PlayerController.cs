using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    private float xBound = 3;
    private Rigidbody playerRb;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        ConstrainPlayerPosition();
    }

    void MovePlayer()//Move the player with arrow keys using the rigidbody
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.back * speed * horizontalInput);
        playerRb.AddForce(Vector3.right * speed * verticalInput);
    }

    void ConstrainPlayerPosition()//Limit the player movement on the x axis so that he cannot leave the screen
    {
        if (transform.position.x < -xBound)
        {
            
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
            playerRb.velocity = new Vector3(0, 0,0);
            
        }
        else if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
            playerRb.velocity = new Vector3(0, 0, 0);

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))//what happens if we hit an enemy
        {
            Debug.Log("You have collided with an enemy");
        }
         else if (collision.gameObject.CompareTag("Hornet"))//what happens if we hit an hornet
        {
            Debug.Log("You have collided with an hornet");
        }
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Health"))//what happens when we take health
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Flower"))//what happens when we are on a flower
        {
            Debug.Log("You are on a flower");
        }
    }
    
}
