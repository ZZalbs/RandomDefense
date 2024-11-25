using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyWaypoints : MonoBehaviour
{
    public static EnemyWaypoints pub_Instance { get; private set; }

    public Transform[] points;
    public int length;

    private void Awake()
    {
        SetSingleTon();
        SetWayPoint();
    }

    void SetSingleTon()
    {
        if(pub_Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        pub_Instance = this;
    }

    void SetWayPoint()
    {
        length = transform.childCount;
        points = new Transform[length];
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }
    }
}
