using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalControl : MonoBehaviour
{

    //public GameObject MainText;
    PlayerController player;
    GameObject player1,player2,player3,player4;

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
        player1 = GameObject.FindWithTag("Player1");
        player2 = GameObject.FindWithTag("Player2");
        player3 = GameObject.FindWithTag("Player3");
        player4 = GameObject.FindWithTag("Player4");

        if (collider.gameObject.tag == "Player1")
        {
            Debug.Log("呼び出し");
            //player.LapNum();
            //PlayerController.instance.LapNum();
            player1.GetComponent<PlayerController>().LapNum();
        }
        else if (collider.gameObject.tag == "Player2")
        {
            Debug.Log("呼び出し2");
            //player.LapNum();
            //PlayerController.instance.LapNum();
            player2.GetComponent<PlayerController>().LapNum();
        }
        else if (collider.gameObject.tag == "Player3")
        {
            Debug.Log("呼び出し3");
            //player.LapNum();
            //PlayerController.instance.LapNum();
            player3.GetComponent<PlayerController>().LapNum();
        }
        else if (collider.gameObject.tag == "Player4")
        {
            Debug.Log("呼び出し4");
            //player.LapNum();
            //PlayerController.instance.LapNum();
            player4.GetComponent<PlayerController>().LapNum();
        }
        //通過をタグ（Player1みたいなの）で判定して、通過したプレイヤーの関数を呼び出して関数内で周回数や通過場所などを管理？
    }


}
