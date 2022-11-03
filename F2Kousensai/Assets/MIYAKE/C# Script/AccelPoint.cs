using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // var worldRotate = this.transform.Transformrotation(0, 0, 40);
        other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 40), ForceMode.VelocityChange);
    }
}