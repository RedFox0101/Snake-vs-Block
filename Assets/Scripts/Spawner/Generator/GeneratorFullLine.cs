using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Generator/FullLineGenerator")]
public class GeneratorFullLine : Generator
{
    public override void Generate(SpawnPoint[] spawnPoints, GameObject generateElement, Transform container)
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            GenerateElement(spawnPoints[i].transform.position, generateElement, container);
        }
    }
}
