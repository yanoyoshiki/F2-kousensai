using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelPoint_shortcut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IEnumerator defeat = Defeat();
        StartCoroutine(defeat);
    }
    IEnumerator Defeat() 
    {
        yield return new WaitForSeconds(4);
        // Destroy (gameObject);
        this.gameObject.SetActive (false);
    }
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, 80), ForceMode.VelocityChange);
    }
}