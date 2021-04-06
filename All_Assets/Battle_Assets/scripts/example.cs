using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class example : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if(Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if(Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }



        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
           transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        } 
        if(Input.GetKey(KeyCode.LeftArrow))
        {
           transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }
         if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }


    }
}
