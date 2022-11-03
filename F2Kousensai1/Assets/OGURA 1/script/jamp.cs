using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jamp : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, 20), ForceMode.VelocityChange);
    }
}