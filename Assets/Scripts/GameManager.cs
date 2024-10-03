using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    ObjectPoolManager poolManager;

    void Start()
    {
        poolManager = GetComponent<ObjectPoolManager>();
        GameStart();
    }

    void GameStart()
    {
        poolManager.InitPool();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
