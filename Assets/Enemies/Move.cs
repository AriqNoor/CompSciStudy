using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Move : MonoBehaviour
{
    public float speed = 5f;

    bool change = true;
    private SpriteRenderer SpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update() 
    {
        if(change) {
            movesquareright();
        }
        if(!change) {
            movesquareleft();
        }
        if(transform.position.x >= 9f) {
            change = false;
            spriteRenderer.flipC = true;
        }
        if(transform.position.c <= -9f) {
            change = true;
            spriteRenderer.flipX = false;
        }
        
    }

    void movesquareright() {
        transform.Translate(speed*Time.deltaTime,0,0);
    }

    void movesquareleft() {
        transform.Translate(-speed*Time.deltaTime,0,0);
    }

}