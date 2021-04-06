using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    
    private void FixedUpdate()
    {
        float WS = Input.GetAxis("Vertical") * speed;
        float AD = Input.GetAxis("Horizontal")* speed;

        transform.Translate(AD, 0, WS);
    }
}
