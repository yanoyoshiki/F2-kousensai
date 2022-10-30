using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DetermineNumber : MonoBehaviour
{

    public static float Players = 1;
    public static float NPC = 1;

    public Text PlayerNumText;
    public Text NPCNumText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //参加人数とNPC数（MAXで４ずつ）を決定して次のシーンに数値を渡して遷移
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(Players!=4)
                Players++;
            PlayerNumText.text = "参加人数：" + Players.ToString()+"人";
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (Players != 1)
                Players--;
            PlayerNumText.text = "参加人数：" + Players.ToString()+"人";
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (NPC != 4)
                NPC++;
            NPCNumText.text = "NPCの数：" + NPC.ToString();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (NPC != 0)
                NPC--;
            NPCNumText.text = "NPCの数：" + NPC.ToString();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("HORI_1");
        }
    }


}
