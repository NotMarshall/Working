using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phhhhhh : MonoBehaviour
{
    // Start is called before the first frame update
          private Rigidbody rb;
          private void Awake()
          {
              rb= GetComponent<Rigidbody>();
          }
    void OnMouseDown()
    {
        rb.AddForce(-transform.forward *500f);
      //  rb.useGravity = true; 

        Debug.Log("Suarkilled");
    }
}
