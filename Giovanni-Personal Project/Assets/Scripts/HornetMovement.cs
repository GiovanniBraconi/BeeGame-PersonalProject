using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HornetMovement : MonoBehaviour
{
    public float speed = 0.2f;
    
    private GameObject flower;
    private Rigidbody hornetRb;
    // Start is called before the first frame update
    void Start()
    {
        hornetRb = GetComponent<Rigidbody>();
        flower = GameObject.FindGameObjectWithTag("Flower");
    }

    // Update is called once per frame
    void Update()//Move the hornet toward the flower
    {
        flower = GameObject.FindGameObjectWithTag("Flower");
        Vector3 flowerDirection = flower.transform.position - transform.position;
        hornetRb.AddForce(flowerDirection * speed);

        
    }
}
