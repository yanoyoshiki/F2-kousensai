using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalControl : MonoBehaviour
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

    void OnTriggerEnter(Collider collider) //���̂����蔲�������ɌĂяo��
    {
        
        if (collider.gameObject.tag == "Player1")
        {
            Debug.Log("�Ăяo��");
            player.LapNum();
            //MainText.SetActive(true); //���O�ɃZ�b�g�����e�L�X�g��\��
        }
        //�ʉ߂��^�O�iPlayer1�݂����Ȃ́j�Ŕ��肵�āA�ʉ߂����v���C���[�̊֐����Ăяo���Ċ֐����Ŏ��񐔂�ʉߏꏊ�Ȃǂ��Ǘ��H
    }


}
