using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    // Create Rigidbody2D variable called rb
    private Rigidbody2D rb;

    // Create Vector2 variable called moveVelocity
    private Vector2 moveVelocity;

    // Start is called before the first frame update
    void Start()
    {
        // Sets rb variable = Rigidbody2D that's attached to the circle GameObject
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // The moveInput allows the circle to be moved based on the "Horizontal" and "Vertical" inputs
        // "Horizontal" are the left and right arrow keys
        // "Vertical" are the up and down arrow keys
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        // MoveInput.normalized allows for diagonal movement
        moveVelocity = moveInput.normalized * speed;
    }

    // Moves the circle
    void FixedUpdate() {
        rb.MovePosition(rb.position+moveVelocity*Time.fixedDeltaTime);
    }
}
