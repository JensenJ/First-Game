using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsSpawner : MonoBehaviour
{

    public Transform[] spawnPoints; //makes this option available in unity

    public GameObject blockPrefab; //makes this option available in unity

    

    void Update() //updates every tick
    { 
        
          
    }

    public void SpawnBlocks()
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
    void OnTriggerEnter()
    {
        SpawnBlocks();
        transform.Translate(0, 0, 45);
    }
}
