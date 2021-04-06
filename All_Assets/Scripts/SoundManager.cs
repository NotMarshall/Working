using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioOrigin;
    public AudioClip punchSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            AudioSource.PlayClipAtPoint(punchSound, transform.position, 1);
        }

        if(Input.GetKeyDown(KeyCode.T))
        {
            audioOrigin.clip = punchSound;
            audioOrigin.Play();
        }
    }
}
