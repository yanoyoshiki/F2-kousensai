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

    void OnTriggerEnter(Collider collider) //���̂����蔲�������ɌĂяo��
    {
        player1 = GameObject.FindWithTag("Player1");
        player2 = GameObject.FindWithTag("Player2");
        player3 = GameObject.FindWithTag("Player3");
        player4 = GameObject.FindWithTag("Player4");

        if (collider.gameObject.tag == "Player1")
        {
            Debug.Log("�Ăяo��");
            //player.LapNum();
            //PlayerController.instance.LapNum();
            player1.GetComponent<PlayerController>().LapNum();
        }
        else if (collider.gameObject.tag == "Player2")
        {
            Debug.Log("�Ăяo��2");
            //player.LapNum();
            //PlayerController.instance.LapNum();
            player2.GetComponent<PlayerController>().LapNum();
        }
        else if (collider.gameObject.tag == "Player3")
        {
            Debug.Log("�Ăяo��3");
            //player.LapNum();
            //PlayerController.instance.LapNum();
            player3.GetComponent<PlayerController>().LapNum();
        }
        else if (collider.gameObject.tag == "Player4")
        {
            Debug.Log("�Ăяo��4");
            //player.LapNum();
            //PlayerController.instance.LapNum();
            player4.GetComponent<PlayerController>().LapNum();
        }
        //�ʉ߂��^�O�iPlayer1�݂����Ȃ́j�Ŕ��肵�āA�ʉ߂����v���C���[�̊֐����Ăяo���Ċ֐����Ŏ��񐔂�ʉߏꏊ�Ȃǂ��Ǘ��H
    }


}
