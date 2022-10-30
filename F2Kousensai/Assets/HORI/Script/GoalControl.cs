using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalControl : MonoBehaviour
{

    //public GameObject MainText;
    public PlayerController player;
    public GameObject playerP;

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
        playerP = GameObject.FindWithTag("Player1");
        if (collider.gameObject.tag == "Player1")
        {
            Debug.Log("呼び出し");
            //player.LapNum();
            //PlayerController.instance.LapNum();
            playerP.GetComponent<PlayerController>().LapNum();
        }
        //通過をタグ（Player1みたいなの）で判定して、通過したプレイヤーの関数を呼び出して関数内で周回数や通過場所などを管理？
    }


}
