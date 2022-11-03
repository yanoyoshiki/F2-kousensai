using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shortcut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision){
        IEnumerator defeat = Defeat();
        StartCoroutine(defeat);
    }
    IEnumerator Defeat() {
        yield return new WaitForSeconds(1);
        Destroy (gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
