using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField] float spawnRate = 1f;

    [SerializeField] GameObject enemyPrefab;

    private float timer = 0f;

    public float spawnRange = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnRate)
        {
            SpawnEnemy();
            timer = 0f;
            spawnRate -= 0.01f;
        }
    }
    void SpawnEnemy()
    {
        // Calculate a random position within the spawn range
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRange, spawnRange), 0f, Random.Range(-spawnRange, spawnRange));

        // Instantiate the enemy prefab at the spawn position
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
