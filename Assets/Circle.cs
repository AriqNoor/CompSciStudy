using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("GAME OVER! TRY AGAIN");
        Destroy(GameObject.Find("Circle"));
    }
}
