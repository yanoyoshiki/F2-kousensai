using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour { 

    public float nowPosi;

    void Start () {
        nowPosi = this.transform.position.y;
    }

    void Update () {
        transform.position = new Vector3(transform.position.x, nowPosi + Mathf.PingPong(Time.time, 5f), transform.position.z);
    }

    // 当たった時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit"); // ログを表示する
    }

}