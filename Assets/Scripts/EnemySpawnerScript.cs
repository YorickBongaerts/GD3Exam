using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public int amountOfEnemies = 0;
    public int enemyMax = 10;
    public GameObject[] enemyPrefabs = new GameObject[4];
    public Material[] enemyMaterials = new Material[4];
    public Bounds[] spawnerBounds = new Bounds[4];

    void Update()
    {
        if (amountOfEnemies < enemyMax)
        {
            SpawnEnemy();
        }
    }
    private void SpawnEnemy()
    {
        GameObject enemy = Instantiate(enemyPrefabs[Random.Range(0, 4)], RandomPointInBounds(spawnerBounds[Random.Range(0, 4)]), Quaternion.identity);
        enemy.GetComponent<MeshRenderer>().material = enemyMaterials[Random.Range(0,4)];
        amountOfEnemies++;
    }
    private Vector3 RandomPointInBounds(Bounds bounds)
    {
        return new Vector3(
            UnityEngine.Random.Range(bounds.min.x, bounds.max.x),
            UnityEngine.Random.Range(bounds.min.y, bounds.max.y),
            UnityEngine.Random.Range(bounds.min.z, bounds.max.z)
        );
    }
}
