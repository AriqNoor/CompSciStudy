using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Move : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {
        
    }

    void Update() 
    {
        movesquareright
    }

    void movesquareright() {
        transform.Translate(speed*Time.deltaTime,0,0);
    }

}