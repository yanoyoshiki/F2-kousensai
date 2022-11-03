using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelPoint_2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, 80), ForceMode.VelocityChange);
    }
}