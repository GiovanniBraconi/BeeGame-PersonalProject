using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 10.0f;
   
    private Rigidbody objectRb; 
    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()//Move the object down and destroy it if it leaves the screen
    {
        objectRb.AddForce(Vector3.left * speed);

        

    }
}
