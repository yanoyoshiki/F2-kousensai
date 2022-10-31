using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Vector3 direction = other.gameObject.GetComponent<Rigidbody>().transform.position - transform.position;
        // other.gameObject.GetComponent<Rigidbody>().AddForceAtPosition(direction.normalized, transform.position);
        // other.gameObject.GetComponent<Transform>().transform.Rotate(0, 180, 0);
        for ( int i  = 0 ; i < 5 ; i++ ){
            other.gameObject.GetComponent<Transform>().transform.Rotate(new Vector3(0, 90, 0));
        }
    }
}
