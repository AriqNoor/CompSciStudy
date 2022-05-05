using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Move : MonoBehaviour
{
    // I plan to gradually change speed
    public float speed = 5f;

    bool change = true;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //Renders Sprite
        spriteRenderer = GetComponent<spriteRenderer>();
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
            //Change direction left
            change = false;
            spriteRenderer.flipX = true;
        }
        if(transform.position.c <= -9f) {
            //Change direction right
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