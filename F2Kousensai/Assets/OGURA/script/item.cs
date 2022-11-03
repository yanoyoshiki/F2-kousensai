using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : itemDel { 

    public float nowPosi;

    void Start () {
        nowPosi = this.transform.position.y;
    }
    private void OnTriggerEnter(Collider other)
    {
            transform.root.gameObject.GetComponent<itemDel>().itemHit();
    }

    void Update () {
        transform.position = new Vector3(transform.position.x, nowPosi + Mathf.PingPong(Time.time, 0.3f), transform.position.z);
    }

}