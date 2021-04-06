using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectionExample : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision c)
    {
      print("Collided with"+c.gameObject.name);
    }
    
      void OnTriggerEnter(Collider c)
    {
        print("Triggered with"+c.gameObject.name);
    }
     
}
