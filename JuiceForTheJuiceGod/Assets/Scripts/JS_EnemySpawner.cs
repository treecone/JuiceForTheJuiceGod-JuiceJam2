using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS_EnemySpawner : MonoBehaviour
{
    public List<GameObject> enemyPrefabs;
    public float xzSize;

    void Start()
    {
        InvokeRepeating("SpawnRandomly", 2f, 1f);
    }

    void Update()
    {
        
    }

    void SpawnRandomly()
    {
        Vector3 spawnLocation = new Vector3(Random.Range(-xzSize, xzSize), 0, Random.Range(-xzSize, xzSize));
        GameObject enemy = Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Count)], spawnLocation, Quaternion.identity) as GameObject;
        enemy.transform.SetParent(this.transform);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(gameObject.transform.position, new Vector3(xzSize*2, 1, xzSize*2));
    }
}