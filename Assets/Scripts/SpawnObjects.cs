using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    //Attaching spawnable objects
    public GameObject Tomato;
    public GameObject Stone;

    

    void Start()
    {
        //Spawning Tomatoes
        InvokeRepeating("SpawningObjects", 2f, 1f);

        //Spawning Stones
        InvokeRepeating("SpawningStones", 10f, 6f);
    }
    

    // Generating Spawn Position
    private Vector3 GenerateSpawnPosition()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-5, 5), 12, 0);

        return spawnPosition;
    }

    //Instantiating Tomatoes
    void SpawningObjects()
    {
        
        Instantiate(Tomato, GenerateSpawnPosition(), Quaternion.identity);

    }

    //Instantiating Stones
    void SpawningStones()
    {

        Instantiate(Stone, GenerateSpawnPosition(), Quaternion.identity);
    }
}
