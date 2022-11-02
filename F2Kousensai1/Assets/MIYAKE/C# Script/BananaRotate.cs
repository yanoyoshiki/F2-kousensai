using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaRotate : MonoBehaviour
{
    Renderer rend;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
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
