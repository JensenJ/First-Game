using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;

    public GameObject blockPrefab;

    private float timeToSpawn = 1f;

    public float spawnRate = 10f;

    //void Update()
    //{
    //    if (Time.time >= timeToSpawn)
    //    {
    //        SpawnBlocks();
    //        timeToSpawn = Time.time + spawnRate;
    //    }
    //}

    void Start()
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
