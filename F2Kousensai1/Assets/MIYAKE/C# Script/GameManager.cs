using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject Sphere;
	// Use this for initialization
	void Start () {
		
	}
    
    void OnCollisionEnter(Collision collision)
    {   
        
        StartCoroutine("Corou1");
        
    }
     //コルーチン関数を定義
    private IEnumerator Corou1() //コルーチン関数の名前
    {
        //コルーチンの内容
        Debug.Log("スタート");
        Sphere.SetActive (false);
        yield return new WaitForSeconds(3.0f);
        Sphere.SetActive (true);
        Debug.Log("スタートから5秒後");
    }

    // public void HeadHit()
    // {
    //     Debug.Log("head");
    // }

    // public void BodyHit()
    // {
    //     Debug.Log("body");
    // }
    // private void OnTriggerEnter(Collider other)
    // {
    //     transform.root.gameObject.GetComponent<hogehoge>().BodyHit();
    // }
}