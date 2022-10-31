using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    Renderer rend;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        // 中心点
        // A sphere that fully encloses the bounding box.
        // Vector3 center = rend.bounds.center;

        // // 回転軸
        // private Vector3 _axis = Vector3.up;

        // // 円運動周期
        // private float _period = 3;
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
        Vector3 center = rend.bounds.center;

        // 回転軸
        Vector3 _axis = Vector3.up;

        // 円運動周期
        float _period = 1;
        
        for(int i=0; i<10; i++){
            // 中心点centerの周りを、軸axisで、period周期で円運動
            other.gameObject.GetComponent<Transform>().transform.RotateAround(
                center,
                _axis,
                360 / _period * Time.deltaTime
            );
        }
        
    }
}
