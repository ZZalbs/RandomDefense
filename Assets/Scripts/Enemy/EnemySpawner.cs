using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float spawnDelay = 1.0f;

    public void SpawnEnemyStart(int enemyCnt)
    {
        StartCoroutine(SpawnEnemyWithDelay(enemyCnt,spawnDelay));
    }

    IEnumerator SpawnEnemyWithDelay(int enemyCnt,float SpawnDelay)
    {
        for (int i = 0; i < enemyCnt; i++)
        {
            yield return new WaitForSeconds(SpawnDelay);
        }
    }
    

}
