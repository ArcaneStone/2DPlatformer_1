using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private List<Transform> _spawnPoints;

    private void Start()
    {
        SpawnCoins();
    }

    private void SpawnCoins()
    {
        foreach (Transform spawnPoint in _spawnPoints)
        {
            Instantiate(_coinPrefab, spawnPoint.position, Quaternion.identity);
        }
    }
}
