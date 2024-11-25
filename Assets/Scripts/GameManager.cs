using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    EnemySpawner spawner;
    public GameObject enemyPrefab;
    Transform enemySpawnPoint;
    [SerializeField] private float spawnDelay = 1.0f;


    void Start()
    {
        enemySpawnPoint = EnemyWaypoints.pub_Instance.points[0];
        GameStart();
    }

    void GameStart()
    {
        SpawnEnemyStart(10);
    }

    public void SpawnEnemyStart(int enemyCnt)
    {
        StartCoroutine(SpawnEnemyWithDelay(enemyCnt, spawnDelay));
    }

    IEnumerator SpawnEnemyWithDelay(int enemyCnt, float SpawnDelay)
    {
        for (int i = 0; i < enemyCnt; i++)
        {
            Instantiate(enemyPrefab,enemySpawnPoint);
            yield return new WaitForSeconds(SpawnDelay);
        }
    }


    void Update()
    {
        
    }
}
