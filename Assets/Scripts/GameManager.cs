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
        spawner.SpawnEnemyStart(10); // 숫자 나중에 변수로 바꾸기
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
