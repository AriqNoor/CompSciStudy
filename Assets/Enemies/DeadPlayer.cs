using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadPlayer : MonoBehaviour
{
    private void onTriggerEnter2D(Collider2D collision) {
        ProcessCollision(collision.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        ProcessCollision(collision.gameObject);
    }

    void ProcessCollision(GameObject collider) {
        if (collider.CompareTag("Damage")) {
            HitPlayer();
        }        
    }

    void HitPlayer() {
        Debug.Log("GAME OVER YOU BUM!");
    }
}
