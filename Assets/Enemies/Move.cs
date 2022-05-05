using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Move : MonoBehaviour
{
    public float speed = 5f;
    
    bool switch = true;

    private SpriteRenderer SpriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<spriteRenderer>();
    }

    void Update() 
    {
        if(switch) {
            movesquareright();
        }
        if(!switch) {
            movesquareleft()
        }
        if(transform.position.x >= 9f){
            switch = false;
            spriteRenderer.flipX = true;
        }
        if transform.position.x <= -9f {
            switch = false;
            spriteRenderer.flipX = true;
        }
    }

    void movesquareright() {
        transform.Translate(speed*Time.deltaTime,0,0);
    }

    void movesquareleft() {
        transform.Translate(-speed*Time.deltaTime,0,0);
    }
}