using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/LevelSpawnDetails", order = 1)]
public class LevelSpawnDetails : ScriptableObject
{
    public string prefabName;

    public int numberOfPrefabsToCreate;

    public Vector2[] spawnPoints;
}

