using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLevelSpawner : MonoBehaviour
{
    public GameObject entityToSpawn;

    public LevelSpawnDetails spawnDetails;

    int instanceNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEntities();
    }

    private void SpawnEntities()
    {
        int currentSpawnPointIndex = 0;

        for (int i = 0; i < spawnDetails.numberOfPrefabsToCreate; i++)
        {
            var currentEntity = Instantiate(entityToSpawn, spawnDetails.spawnPoints[currentSpawnPointIndex], Quaternion.Euler(0, 0, 90));

            currentEntity.name = spawnDetails.prefabName + instanceNumber;

            currentSpawnPointIndex = (currentSpawnPointIndex + 1) % spawnDetails.spawnPoints.Length;

            instanceNumber++;
        }
    }


}
