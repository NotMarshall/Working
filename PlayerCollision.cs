using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript playerScript;
       public void OnTriggerEnter(Collider other)
    {
         if(other.gameObject.tag =="Collectables")
        {
            Destroy(other.gameObject);
        }
    }

 /*   public void OnCollisionEnter (Collision other)
    {
        if(other.gameObject.tag=="Obstacles")
        {
            playerScript.enabled=false;
        }
    }
    */
}
