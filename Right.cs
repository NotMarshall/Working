using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Right : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public float speed = 0.1f;
    public GameObject player;
    bool ispressed = false;
  

    // Update is called once per frame
    void Update()
    {
        if(ispressed)
        {
            player.transform.Translate(speed, 0, 0);
        }
        
    }

        public void OnPointerDown(PointerEventData eventData)
        {
            ispressed = true;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            ispressed = false;
        }

}
