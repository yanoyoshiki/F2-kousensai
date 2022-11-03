using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour { 

    void Start()
    {
        IEnumerator defeat = Defeat();
        StartCoroutine(defeat);
    }
    IEnumerator Defeat() {
        yield return new WaitForSeconds(4);
        Destroy (gameObject);
    }

    void Update () {
        // transform.position = new Vector3(transform.position.x, nowPosi + Mathf.PingPong(Time.time, 5f), transform.position.z);
    }

    // 当たった時に呼ばれる関数
    // void OnCollisionEnter(Collision collision)
    // {
    //     Debug.Log("Hit"); // ログを表示する
    // }

}