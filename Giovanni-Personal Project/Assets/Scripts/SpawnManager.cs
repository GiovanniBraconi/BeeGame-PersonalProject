using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemiesHealthFlowers;
    public GameObject hornet;
    private GameObject flower;
    private float zSpawn = 9;//z of the hornets and max range of the enemy and health spawn
    private float xSpawn = 5.7f;//x of the enemies and health
    private float xHornetRange = 3;//x range of the hornets spawn

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemyHealthFlower", 1, 4f);


    }

    void SpawnEnemyHealthFlower()//Spawn an enemy or health or a flower at a random position(spawnPos)
    {
        float randomZ = Random.Range(-zSpawn, zSpawn);
        int randomIndex = Random.Range(0, enemiesHealthFlowers.Length);

        Vector3 spawnPos = new Vector3(xSpawn, 2, randomZ);

        Instantiate(enemiesHealthFlowers[randomIndex], spawnPos, enemiesHealthFlowers[randomIndex].transform.rotation);
        if (randomIndex == 3)
        {
            Invoke("SpawnHornet", 1f);
        }


    }
    void SpawnHornet()//spawn the hornet at a random position(spawnPos)
    {
        if (Random.value < 0.5f)
            zSpawn = -9;
        else
            zSpawn = 9;
        float randomX = Random.Range(-xHornetRange, xHornetRange);
        Vector3 spawnPos = new Vector3(randomX, 2, zSpawn);
        Instantiate(hornet, spawnPos, hornet.transform.rotation);
    }


    // Update is called once per frame
    void Update()

    {
        
    }

    

    
}
