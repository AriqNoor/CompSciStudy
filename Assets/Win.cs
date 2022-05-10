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
        // This destroys the Circle GameObject and writes stated message under the console if the circle reaches a certain point on the Y - axis
        if(transform.position.y >= 5f) {
            Debug.Log("CONGRATULATIONS! YOU WIN! START OVER IF YOU WANT!");//congratulations when you pass all the squares
            Destroy(GameObject.Find("Circle"));
        }
    }
}
