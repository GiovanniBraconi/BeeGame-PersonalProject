using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private float xDestroy = -5.81f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < xDestroy)//destroy every game object that goes out of the screen
        {
            Destroy(gameObject);
        }
    }
}
