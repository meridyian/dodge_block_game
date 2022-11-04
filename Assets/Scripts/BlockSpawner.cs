using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    // create a spawn point list 
    public Transform[] spawnPoints;

    public GameObject blockPrefab;

    // Start is called before the first frame update
    void Start()
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
