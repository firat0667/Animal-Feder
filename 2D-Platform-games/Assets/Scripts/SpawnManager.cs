using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float SpawnRangeX = 19;
    private float spawnRangeZ = 20;
    private float startDelay = 2;
    //startdelay= ne kadar süre sonra spawn iþlemi baþlýyacak;
    private float spawnInterval = 1.5f;
    // spawn olma sýklýðý
    void Start()
    {   
        InvokeRepeating("SpawnRandomAnimal", startDelay,spawnInterval);
    }

    
    void Update()
    {
      
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, spawnRangeZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
