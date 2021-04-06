using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Left : MonoBehaviour,IPointerDownHandler, IPointerUpHandler
{
    public float speed = -0.1f;
     public GameObject player;
    bool ispressed = false;
   
    
       void Update()
    {
        if(ispressed)
        {
            player.transform.Translate(speed, 0, 0);
       //   player.AddForce(0,0,500f*Time.deltaTime);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed =true;

    }

     public void OnPointerUp(PointerEventData eventData)
    {
        ispressed =false;
    }
}
