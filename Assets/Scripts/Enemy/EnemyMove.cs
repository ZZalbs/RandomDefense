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
        targetMovePos = EnemyWaypoints.pub_Instance().points[wayPointNum];
    }
    void Update()
    {
        if(Vector2.Distance(targetMovePos.position,transform.position)< 0.05f)
        {
            wayPointNum++;
        }
        Vector2 dir = (targetMovePos.position - transform.position).normalized;
        transform.Translate(dir * moveSpeed * Time.deltaTime);
    }
}
