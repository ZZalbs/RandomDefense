using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public PoolableObject poolObj;
    [SerializeField] private float spawnDelay = 1.0f;

    public void SpawnEnemyStart(int enemyCnt)
    {
        StartCoroutine(SpawnEnemyWithDelay(enemyCnt,spawnDelay));
    }

    IEnumerator SpawnEnemyWithDelay(int enemyCnt,float SpawnDelay)
    {
        yield return new WaitForSeconds(SpawnDelay);
    }
    

}
