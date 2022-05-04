using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square1 : MonoBehaviour
{
    // Start is called before the first frame update
    float phase = 0;
    float speed = 1;
    float phaseDirection = 1;

    void Update() {
        transform.position = Vector3.Lerp(back, forth, phase);
        phase += Time.deltaTime * speed * phaseDirection;
        if(phase >=1 || phase <=0) phaseDirection *=-1;
    }
}
