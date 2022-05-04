using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square1Move : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 0f;

    private void FixedUpdate() {
        transform.Translate(new Square1Move (1f, 0f) * moveSpeed * Time.deltaTime);
    }
}
