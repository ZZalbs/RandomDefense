using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyWaypoints : MonoBehaviour
{
    //ΩÃ±€≈Ê
    private static EnemyWaypoints priv_instance;
    public EnemyWaypoints pub_Instance()
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
