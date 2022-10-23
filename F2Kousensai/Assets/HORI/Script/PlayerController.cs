using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float lap = 0; //現在の周回数
    float road = 0; //チェックポイントを通過したか

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RoadNum()
    {
        if (road == 0)
        {
            Debug.Log("一周目チェックポイント");
            road++;
        }
        else if (road == 1)
        {
            Debug.Log("二周目チェックポイント");
            road++;
        }
        else if (road == 2)
        {
            Debug.Log("三周目チェックポイント");
            road++;
        }
    }

    public void LapNum()
    {
        if (lap == 0)
        {
            Debug.Log("一周目");
            lap++;
        }else if (lap == 1 && road == 1)
        {
            Debug.Log("二周目");
            lap++;
        }else if (lap == 2 && road == 2)
        {
            Debug.Log("三周目");
            lap++;
        }else if (lap == 3 && road == 3)
        {
            Debug.Log("ゴール");
            lap++;
        }
        //何周目かを管理
    }
}
