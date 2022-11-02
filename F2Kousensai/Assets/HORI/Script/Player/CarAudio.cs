using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAudio : MonoBehaviour
{

    public AudioSource ausd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (ausd.pitch < 5)
            {
                ausd.pitch += 0.02f;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (ausd.pitch < 5)
            {
                ausd.pitch += 0.02f;
            }
        }
        if(ausd.pitch > 1.00f)
        {
            ausd.pitch -= 0.01f;
        }
    }
}
