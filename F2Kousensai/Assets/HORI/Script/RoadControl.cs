using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadControl : MonoBehaviour
{
    //public GameObject MainText;
    PlayerController player;
    GameObject player1, player2, player3, player4;


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
            Debug.Log("チェック1");
            //player.LapNum();
            //PlayerController.instance.LapNum();
            player1.GetComponent<PlayerController>().RoadNum();
        }
        else if (collider.gameObject.tag == "Player2")
        {
            Debug.Log("チェック2");
            //player.LapNum();
            //PlayerController.instance.LapNum();
            player2.GetComponent<PlayerController>().RoadNum();
        }
        else if (collider.gameObject.tag == "Player3")
        {
            Debug.Log("チェック3");
            //player.LapNum();
            //PlayerController.instance.LapNum();
            player3.GetComponent<PlayerController>().RoadNum();
        }
        else if (collider.gameObject.tag == "Player4")
        {
            Debug.Log("チェック4");
            //player.LapNum();
            //PlayerController.instance.LapNum();
            player4.GetComponent<PlayerController>().RoadNum();
        }


        //通過をタグ（Player1みたいなの）で判定して、通過したプレイヤーの関数を呼び出して関数内で周回数や通過場所などを管理？
    }
}
