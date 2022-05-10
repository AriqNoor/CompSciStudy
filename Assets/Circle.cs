using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // This destroys the Circle GameObject and writes stated message under the console if the circle collides with any of the squares
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("GAME OVER! TRY AGAIN");//whenever the ball collides with the squares, the ball gets destroyed and it says "game over"
        Destroy(GameObject.Find("Circle"));// whenever the ball gets past all the squares, it says congrats you won.
    }
}
