using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    EnemySpawner spawner;

	

	void Start()
    {
        spawner = GetComponent<EnemySpawner>();
        GameStart();
    }

    void GameStart()
    {
        spawner.SpawnEnemyStart(10); // ���� ���߿� ������ �ٲٱ�
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
