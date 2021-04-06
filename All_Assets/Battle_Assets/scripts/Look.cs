using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace player 
{
     public class Look : MonoBehaviour
      {
            public float sensitivity;
            public GameObject Player;
            private Vector2 ML;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void Update()
    {
        Vector2 CL = new Vector2(Input.GetAxisRaw("Mouse X")* sensitivity,Input.GetAxisRaw("Mouse Y")*sensitivity );
        ML +=CL;

        ML.y = Mathf.Clamp(ML.y, -90, 90);

        transform.localRotation = Quaternion.AngleAxis(-ML.y, Vector3.right);
        Player.transform.localRotation = Quaternion.AngleAxis(ML.x, Player.transform.up);

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }
        
    }
    
}

}