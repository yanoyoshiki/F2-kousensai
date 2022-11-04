using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMove : MonoBehaviour
{
    public float nowPosi;

    void Start () {
        nowPosi = this.transform.position.x;
    }

    void Update () {
        transform.position = new Vector3(nowPosi - Mathf.PingPong(Time.time, 5f), transform.position.y, transform.position.z);
    }
}
