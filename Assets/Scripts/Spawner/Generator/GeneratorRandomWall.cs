using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Generator/RandomLineGeneratorWall")]
public class GeneratorRandomWall : Generator
{
    [SerializeField] private int _spawnChance;
    [SerializeField] private float _offsetY;

    public override void Generate(SpawnPoint[] spawnPoints, GameObject generateElement, Transform container)
    {
        GenerateRandomLineElements(spawnPoints, generateElement, _spawnChance, container);
    }

    private void GenerateRandomLineElements(SpawnPoint[] spawnPoints, GameObject generateElement, int spawChance, Transform container)
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (Random.Range(0, 100) < spawChance)
            {
                GameObject element = GenerateElement(spawnPoints[i].transform.position, generateElement, container,_offsetY);
               
            }
        }
    }

  
}
