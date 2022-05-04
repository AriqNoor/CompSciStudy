using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Move : MonoBehaviour
{
    Vector3 pointA = new Vector3(0, 0, 0);
    Vector3 pointB = new Vector3(1, 1, 1);

    void Start() {

    }
    
    void Update()
    {
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }
}