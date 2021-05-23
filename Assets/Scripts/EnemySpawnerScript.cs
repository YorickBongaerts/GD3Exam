using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public int amountOfEnemies = 0;
    public int enemyMax = 10;
    public GameObject[] enemyPrefabs = new GameObject[12];
    public Material[] enemyMaterials = new Material[4];
    public Collider[] spawnerColliders = new Collider[4];

    void FixedUpdate()
    {
        if (amountOfEnemies < enemyMax)
        {
            SpawnEnemy();
        }
    }
    private void SpawnEnemy()
    {
        int enemyPrefabNumber = Random.Range(0, 12);
        GameObject enemy = Instantiate(enemyPrefabs[enemyPrefabNumber], RandomPointInBounds(spawnerColliders[Random.Range(0, 4)].bounds), Quaternion.identity);
        if (enemyPrefabNumber < 6)
        {
            enemy.transform.GetChild(0).GetComponent<MeshRenderer>().material = enemyMaterials[Random.Range(0, 2)];
        }
        else
        {
            enemy.transform.GetChild(0).GetComponent<MeshRenderer>().material = enemyMaterials[Random.Range(2, 4)];
        }
        amountOfEnemies++;
    }
    private Vector3 RandomPointInBounds(Bounds bounds)
    {
        return new Vector3(
            UnityEngine.Random.Range(bounds.min.x, bounds.max.x),
            0,
            UnityEngine.Random.Range(bounds.min.z, bounds.max.z)
        );
    }
}
