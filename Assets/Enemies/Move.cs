using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Move : MonoBehaviour
{
 
    Vector2 pointA = new Vector3(-9, 4);
    Vector2 pointB = new Vector3(9, 4);
 
    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    void Update()
    {
        transform.position = Vector2.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }
}