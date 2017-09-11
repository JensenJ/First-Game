using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsSpawner : MonoBehaviour
{

    public Transform[] spawnPoints; //makes this option available in unity
    public Transform floorSpawnPoint; //makes this option available in unity

    public GameObject blockPrefab; //makes this option available in unity
    public GameObject floorPrefab; //makes this option available in unity
    public GameObject floorInstance;
    public GameObject blockInstance;

    public void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length); //Works out where to spawn the blocks

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                blockInstance = (GameObject)Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);// spawns blocks accross the row apart from the one block randomly selected
                Destroy(blockInstance, 5);
            }
        }
    }
    void OnTriggerEnter()// when the player enters the trigger box
    {
        //SpawnBlocks(); //calls spawn blocks method
        transform.Translate(0, 0, 45); //moves spawners and trigger forward
        floorInstance = (GameObject)Instantiate(floorPrefab, floorSpawnPoint.position, Quaternion.identity); // spawns the floor in for the next wave
        Destroy(floorInstance, 5);
        
    }
}

