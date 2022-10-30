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
        //�Q���l����NPC���iMAX�łS���j�����肵�Ď��̃V�[���ɐ��l��n���đJ��
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(Players!=4)
                Players++;
            PlayerNumText.text = "�Q���l���F" + Players.ToString()+"�l";
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (Players != 1)
                Players--;
            PlayerNumText.text = "�Q���l���F" + Players.ToString()+"�l";
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (NPC != 4)
                NPC++;
            NPCNumText.text = "NPC�̐��F" + NPC.ToString();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (NPC != 0)
                NPC--;
            NPCNumText.text = "NPC�̐��F" + NPC.ToString();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("HORI_1");
        }
    }


}
