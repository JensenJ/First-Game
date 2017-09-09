using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;

    public GameObject blockPrefab;

    private float timeToSpawn = 1f;

    public float spawnRate = 10f;

    

    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            transform.Translate(0, 0, 160);
            timeToSpawn = Time.time + spawnRate;
        }
    }

    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}
