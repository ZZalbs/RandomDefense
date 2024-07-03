using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyWaypoints : MonoBehaviour
{
    //싱글톤. 이거 나중에 게임매니저에 합치기
    //https://velog.io/@xoaud321/Unity-%EC%9C%A0%EB%8B%88%ED%8B%B0-%EC%8B%B1%EA%B8%80%ED%84%B4-%ED%8C%A8%ED%84%B4-%EC%82%AC%EC%9A%A9%ED%95%B4-%EB%A7%90%EC%95%84-Singleton-Pattern
    //참고
    private static EnemyWaypoints priv_instance;
    public static EnemyWaypoints pub_Instance()
    {
        if(priv_instance == null)
        {
            priv_instance = new EnemyWaypoints();
        }
        return priv_instance;
    }


    public Transform[] points;

    private void Awake()
    {
        points = new Transform[transform.childCount];
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }
    }
}
