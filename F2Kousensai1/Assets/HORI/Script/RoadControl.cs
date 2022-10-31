using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadControl : MonoBehaviour
{
    //public GameObject MainText;
    public PlayerController player;


    // Start is called before the first frame update
    void Start()
    {
        //MainText.SetActive(false);
        //player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider) //物体がすり抜けた時に呼び出す
    {

        if (collider.gameObject.tag == "Player1")
        {
            Debug.Log("呼び出し2");
            player.RoadNum();
            //MainText.SetActive(true); //事前にセットしたテキストを表示
        }
        //通過をタグ（Player1みたいなの）で判定して、通過したプレイヤーの関数を呼び出して関数内で周回数や通過場所などを管理？
    }
}
