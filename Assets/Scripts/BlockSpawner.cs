using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    // create a spawn point list 
    public Transform[] spawnPoints;

    public GameObject blockPrefab;

    public float timeBetweenWaves = 1f;

    private float timeToSpwan = 2f;

    // Start is called before the first frame update
    void Update()
    {
        // dont want it to happen at each frame, add time

        if(Time.time >= timeToSpwan)
        {
            SpawnBlocks();
            timeToSpwan = Time.time + timeBetweenWaves;
        }
        
    }

    // Update is called once per frame
    void SpawnBlocks()
    {
        // select random spawner
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            // do smth for spawnPoints.Length amount of times

            if (randomIndex != i)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }


        }
    }
}
