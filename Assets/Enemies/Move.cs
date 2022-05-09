using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Move : MonoBehaviour
{
    public float speed = 10f;

    // Set bool to allow square to change direction
    bool change = true;

    // Creates SpriteRenderer variable called spriteRenderer
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        // Set spriteRenderer variable = SpriteRenderer that's attached to the square GameObject
        spriteRenderer = GetComponent<spriteRenderer>();
    }

    // Update is called once per frame
    void Update() 
    {
        // Checks to see if "change" is true, if it is, the square moves right
        if(change) {
            movesquareright();
        }

        // Checks to see if "change" is false, if it is, the square moves left
        if(!change) {
            movesquareleft();
        }
        
        // 9f or -9f is the x-coordinate to which the square changes direction
        if(transform.position.x >= 9f) {
            // Change direction left
            change = false;
            spriteRenderer.flipX = true;
        }
        if(transform.position.x <= -9f) {
            // Change direction right
            change = true;
            spriteRenderer.flipX = false;
        }
        
    }

    // Moves square right due to positive speed
    void movesquareright() {
        transform.Translate(speed*Time.deltaTime,0,0);
    }

    // Moves square left due to negative speed
    void movesquareleft() {
        transform.Translate(-speed*Time.deltaTime,0,0);
    }

}