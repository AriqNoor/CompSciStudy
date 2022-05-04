using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{

    public float MoveSpeed, JumpForce;

    public bool Jumping;

    public Rigidbody2D RG2D;
    // Start is called before the first frame update
    void Start()
    {
        RG2D = GetComponent<Rigidbody2D>();

        MoveSpeed = 5f;
        JumpForce = 5f;

        Jumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        float MovX = Input.GetAxisRaw("Horizontal");
        float MovY = Input.GetAxisRaw("Vertical");
        
        //Horizontal Movement
         if(MovX != 0)
        {
            RG2D.velocity = new Vector2(MoveSpeed * MovX, RG2D.velocity.y);
        }

         //Jumping
         if (Input.GetKey(KeyCode.Space))
        {
           

           if (Jumping == false)
        {
            RG2D.velocity = new Vector2(RG2D.velocity.x, JumpForce);
            Jumping = true;

           Invoke("Action", 1f);

            
            
        }
           

            
            
        }
        



         //Crouching
         if(MovY == -1)
        {
            transform.localScale = new Vector2(1f, 0.5f);
        }

        else
        {
            transform.localScale = new Vector2(1f, 1f);
        }
    }

    void OnCollissionEnter2D(Collision2D col)
    {
        Jumping = false;
    }
    private void Action()
    {
        Jumping = false;
    }
}
