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

    void OnTriggerEnter(Collider collider) //���̂����蔲�������ɌĂяo��
    {

        if (collider.gameObject.tag == "Player1")
        {
            Debug.Log("�`�F�b�N1");
            //player.LapNum();
            //PlayerController.instance.LapNum();
            player1.GetComponent<PlayerController>().RoadNum();
        }
        else if (collider.gameObject.tag == "Player2")
        {
            Debug.Log("�`�F�b�N2");
            //player.LapNum();
            //PlayerController.instance.LapNum();
            player2.GetComponent<PlayerController>().RoadNum();
        }
        else if (collider.gameObject.tag == "Player3")
        {
            Debug.Log("�`�F�b�N3");
            //player.LapNum();
            //PlayerController.instance.LapNum();
            player3.GetComponent<PlayerController>().RoadNum();
        }
        else if (collider.gameObject.tag == "Player4")
        {
            Debug.Log("�`�F�b�N4");
            //player.LapNum();
            //PlayerController.instance.LapNum();
            player4.GetComponent<PlayerController>().RoadNum();
        }


        //�ʉ߂��^�O�iPlayer1�݂����Ȃ́j�Ŕ��肵�āA�ʉ߂����v���C���[�̊֐����Ăяo���Ċ֐����Ŏ��񐔂�ʉߏꏊ�Ȃǂ��Ǘ��H
    }
}
