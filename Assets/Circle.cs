using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // This destroys the Circle GameObject and writes stated message under the console
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("GAME OVER! TRY AGAIN");
        Destroy(GameObject.Find("Circle"));
    }
}
