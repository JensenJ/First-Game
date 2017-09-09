using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsSpawner : MonoBehaviour
{

    public Transform[] spawnPoints; //makes this option available in unity

    public GameObject blockPrefab; //makes this option available in unity

    private float timeToSpawn = 1f;

    public float spawnRate = 10f; 

    

    void Update() //updates every tick
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            transform.Translate(0, 0, 160); //Moves obstacle spawners forward after they have spawned their blocks
            timeToSpawn = Time.time + spawnRate; //resets cycle
        }
    }

    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length); //Works out where to spawn the blocks

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i) 
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);// spawns blocks accross the row apart from the one block randomly selected
            }
        }
    }
}
