using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankAlgorithm : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        // ベクトル
        Vector3 a = new Vector3(1, 2, 3);
        Vector3 b = new Vector3(4, 5, 6);

        // 内積を求める
        float dot = Vector3.Dot(a, b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
