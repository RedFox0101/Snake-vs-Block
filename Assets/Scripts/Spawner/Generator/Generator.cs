using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Generator : ScriptableObject
{
    public abstract void Generate(SpawnPoint[] spawnPoints, GameObject generateElement, Transform container);


    protected GameObject GenerateElement(Vector3 spawnPoint, GameObject generateElement, Transform container, float offsetY = 0)
    {
        spawnPoint.y -= offsetY;

        return Instantiate(generateElement, spawnPoint, Quaternion.identity,container);
    }
}
