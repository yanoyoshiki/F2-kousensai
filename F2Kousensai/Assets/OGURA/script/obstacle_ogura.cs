using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_ogura : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    // void OnCollisionEnter(Collision collision)
    // {
    //     IEnumerator defeat = Defeat();
    //     StartCoroutine(defeat);
    // }
    IEnumerator Defeat() {
        yield return new WaitForSeconds(4);
        // Destroy (gameObject);
        this.gameObject.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.activeSelf){
            IEnumerator defeat = Defeat();
            StartCoroutine(defeat);
        }
    }
}
