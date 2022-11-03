using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banana_destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IEnumerator defeat = Defeat();
        StartCoroutine(defeat);
    }
    IEnumerator Defeat() {
        yield return new WaitForSeconds(4);
        Destroy (gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
