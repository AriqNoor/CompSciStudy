using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square1Move : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb ;
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();


    }
    private void FixedUpdate() {
        rb.velocity = newVector2 (2f,of);
    }
}
