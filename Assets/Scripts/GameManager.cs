using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    ObjectPoolManager poolManager;
    EnemySpawner spawner;

    void Start()
    {
        poolManager = GetComponent<ObjectPoolManager>();
        spawner = GetComponent<EnemySpawner>();
        GameStart();
    }

    void GameStart()
    {
        poolManager.InitPool();
        spawner.SpawnEnemyStart(10); // ���� ���߿� ������ �ٲٱ�
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
