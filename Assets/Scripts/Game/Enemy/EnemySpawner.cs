using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;

    [SerializeField]
    private float _minimumSpawnTime;

    [SerializeField]
    private float _maximumSpawnTime;

    private float _timeUntilSpawn;

    void Awake()
    {
        SetTimeUntilSpawn();
    }

    void Update()
    {
        _timeUntilSpawn -= Time.deltaTime;  // FIXED
        if (_timeUntilSpawn <= 0)
        {
            Instantiate(_enemyPrefab, transform.position, Quaternion.identity);  // FIXED
            SetTimeUntilSpawn();
        }
    }

    private void SetTimeUntilSpawn()   // FIXED spelling
    {
        _timeUntilSpawn = Random.Range(_minimumSpawnTime, _maximumSpawnTime);
    }
}

