using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int pointIndex = 0;
    private Vector3 targetPosition = Vector3.zero;
    public float speed = 4;

    void Start()
    {
        targetPosition = WayPoints.Instance.GetWayPoint(pointIndex);
    }

    void Update()
    {
        transform.Translate((targetPosition - transform.position).normalized * speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            MoveNextPoint();
        }
    }

    private void MoveNextPoint()
    {
        pointIndex++;

        if (pointIndex < WayPoints.Instance.GetLength())
        {
            targetPosition = WayPoints.Instance.GetWayPoint(pointIndex);
        }
        else
        {
            Destroy(gameObject); 
        }
    }
}
