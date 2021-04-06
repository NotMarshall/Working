using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public float maxX;
    public float minX;
    public float force = 500f;
    public Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 playerPos =transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x, minX, maxX);
        transform.position = playerPos;

        

/*
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(1f*Time.deltaTime, 0, 0);
     //      rigidbody.AddForce(500f*Time.deltaTime,0,0);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + new Vector3(-1f*Time.deltaTime, 0, 0);
      //   rigidbody.AddForce(-500f*Time.deltaTime,0,0);
        }

            */
         rigid.AddForce(0,0,force*Time.deltaTime);
   
    }
   
}
