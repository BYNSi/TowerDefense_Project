using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int pointIndex = 0;
    private Vector3 targetPosition = Vector3.zero;
    public float speed = 20;

    void Start()
    {
        targetPosition = Waypoints.Instance.GetWaypoint(pointIndex);
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            MoveNextPoint();
        }
    }

    private void MoveNextPoint()
    {
        pointIndex++;
        if (pointIndex >= Waypoints.Instance.GetLength())
        {
            Die();
            return;
        }
        targetPosition = Waypoints.Instance.GetWaypoint(pointIndex);
    }

    void Die()
    {
        Destroy(gameObject);
        EnemySpawner.Instance.DecreateEnemyCount();
    }
}
