using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    // 中心点
    // [SerializeField] private Vector3 _center = (GameObject.Find("Banana")).GetComponent<Renderer>().bounds.center;
    [SerializeField] private Vector3 _center = this.GetComponent<Renderer>().bounds.center;

    // 回転軸
    [SerializeField] private Vector3 _axis = Vector3.up;

    // 円運動周期
    [SerializeField] private float _period = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // // 中心点centerの周りを、軸axisで、period周期で円運動
        // transform.RotateAround(
        //     _center,
        //     _axis,
        //     360 / _period * Time.deltaTime
        // );
    }

    private void OnTriggerEnter(Collider other)
    {
        // Vector3 direction = other.gameObject.GetComponent<Rigidbody>().transform.position - transform.position;
        // other.gameObject.GetComponent<Rigidbody>().AddForceAtPosition(direction.normalized, transform.position);
        // other.gameObject.GetComponent<Transform>().transform.Rotate(0, 180, 0);
        // 中心点centerの周りを、軸axisで、period周期で円運動
        other.gameObject.GetComponent<Transform>().transform.RotateAround(
            (GameObject.Find("Banana")).GetComponent<Renderer>().bounds.center,
            _axis,
            360 / _period * Time.deltaTime
        );
    }
}
