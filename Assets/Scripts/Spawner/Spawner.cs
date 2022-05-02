using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("General")]

    [SerializeField] private Transform _container;
    [SerializeField] private int _distanceBetweenFullLine;
    [SerializeField] private int _distanceBetweenRandomLine;
    [SerializeField] private Generator[] _generatorsBlocks;
    [SerializeField] private Generator _generatorWall;
    [SerializeField] private Generator _generatorBonus;

    [Header("Block")]
    [SerializeField] private Block _blockTemplete;
    private SpawnPoint[] _blockSpawnPoints;

    [Header("Wall")]

    [SerializeField] private Wall _wallTemplate;
    private WalllSpawnPoint[] _wallSpawnPoints;

    [Header("Bonus")]
    [SerializeField] private Bonus _bonusTemplate;

    private void Start()
    {
        _blockSpawnPoints = GetComponentsInChildren<BlockSpawnPoint>();
        _wallSpawnPoints = GetComponentsInChildren<WalllSpawnPoint>();

        StartCoroutine(Spawn());
    }

    private void MoveSpawner(int distance)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + distance, transform.position.z); ;
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            MoveSpawner(_distanceBetweenFullLine);
            _generatorsBlocks[Random.Range(0, _generatorsBlocks.Length)].Generate(_blockSpawnPoints, _blockTemplete.gameObject, _container);
            _generatorWall.Generate(_wallSpawnPoints, _wallTemplate.gameObject, _container);
            MoveSpawner(_distanceBetweenRandomLine);
            _generatorBonus.Generate(_blockSpawnPoints, _bonusTemplate.gameObject, _container);
            yield return new WaitForSeconds(2);
        }
    }
}

