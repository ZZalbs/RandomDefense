using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Rigidbody2D enemyRb;

    private float moveSpeed = 2f;

    private Transform targetMovePos;

    private int wayPointNum;

    void Start()
    {
        SetNextWaypoint(0);
    }
    void SetNextWaypoint(int pointNum)
    {
        targetMovePos = EnemyWaypoints.pub_Instance.points[pointNum];
    }

    void Update()
    {
        if(Vector2.Distance(targetMovePos.position,transform.position)< 0.05f)
        {
            CheckLastPointArrived();
            SetNextWaypoint(wayPointNum++);
        }
        Vector2 dir = (targetMovePos.position - transform.position).normalized;
        transform.Translate(dir * moveSpeed * Time.deltaTime);
    }

    void CheckLastPointArrived()
    {
        if(wayPointNum==EnemyWaypoints.pub_Instance.length)
        {
            wayPointNum = 0;
            Destroy(gameObject);
        }
    }
}
