using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= 5f) {
            Debug.Log("CONGRATULATIONS! YOU WIN! START OVER IF YOU WANT!");
            Destroy(GameObject.Find("Circle"));
        }
    }
}
