using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square1 : MonoBehaviour
{
    // Update is called once per frame
    private void FixedUpdate() {
        transform.position = new Vector2 (8f,transform.position.y);
    }
}
