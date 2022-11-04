using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulldozer : MonoBehaviour { 

    public float nowPosi;

    void Start () {
        nowPosi = this.transform.position.x;
    }

    void Update () {
        transform.position = new Vector3(nowPosi - Mathf.PingPong(Time.time, 5f), transform.position.y, transform.position.z);
    }

    // 当たった時に呼ばれる関数
    // void OnCollisionEnter(Collision collision)
    // {
    //     Debug.Log("Hit"); // ログを表示する
    // }

}