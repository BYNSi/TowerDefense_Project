using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class WayPoints : MonoBehaviour
{

    public static WayPoints Instance {get; private set;}

    private List<Transform> WayPointList;


    private void Awake()
    {
        Instance = this;
        Init();
    }
 


    private void Init()
    {
        Transform[] transforms = transform.GetComponentsInChildren<Transform>();
        WayPointList = new List<Transform>(transforms);
        WayPointList.RemoveAt(0);

    }
    public int GetLength()
    {
        return WayPointList.Count;
    }
    public Vector3 GetWayPoint(int index)
    {
        return  WayPointList[index].position;
    }
}
