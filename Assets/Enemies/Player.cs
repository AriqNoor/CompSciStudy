using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    public Rigidbody2D RigidBody2D;
    public Vector2 moveVelocity;

    // Start is called before the first frame update
    void Start()
    {
        RigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed;
    }

    void FixedUpdate() {
        RigidBody2D.MovePosition(RigidBody2D.position+moveVelocity*Time.fixedDeltaTime);
    }
}
