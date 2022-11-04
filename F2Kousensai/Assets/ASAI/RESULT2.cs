using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class RESULT2 : MonoBehaviour
{
    public GameObject score_object1 = null; // Textオブジェクト
    public GameObject score_object2 = null; // Textオブジェクト
    public GameObject score_object3 = null; // Textオブジェクト
    public GameObject score_object4 = null; // Textオブジェクト
    public GameObject score_object5 = null; // Textオブジェクト

    string[] result = new string[5];
    int[] resultSeconds = new int[5];
    string[] playerName = new string[5];



    // Start is called before the first frame update
    void Start()
    {
        int i, j;
        int resultSeconds_tmp;
        string playerName_tmp;
        string result_tmp;


        for (i = 0; i < 9; ++i)
        {
            for (j = i + 1; j < 9; ++j)
            {
                if (RESULT1.best_resultSeconds_sum[i] > RESULT1.best_resultSeconds_sum[j])
                {

                    resultSeconds_tmp = RESULT1.best_resultSeconds_sum[i];
                    RESULT1.best_resultSeconds_sum[i] = RESULT1.best_resultSeconds_sum[j];
                    RESULT1.best_resultSeconds_sum[j] = resultSeconds_tmp;

                    result_tmp = RESULT1.best_result_sum[i];
                    RESULT1.best_result_sum[i] = RESULT1.best_result_sum[j];
                    RESULT1.best_result_sum[j] = result_tmp;

                    playerName_tmp = RESULT1.best_playerName_sum[i];
                    RESULT1.best_playerName_sum[i] = RESULT1.best_playerName_sum[j];
                    RESULT1.best_playerName_sum[j] = playerName_tmp;



                }
            }
        }

        RESULT1.best_result[0] = RESULT1.best_result_sum[0];
        RESULT1.best_result[1] = RESULT1.best_result_sum[1];
        RESULT1.best_result[2] = RESULT1.best_result_sum[2];
        RESULT1.best_result[3] = RESULT1.best_result_sum[3];
        RESULT1.best_result[4] = RESULT1.best_result_sum[4];

        RESULT1.best_resultSeconds[0] = RESULT1.best_resultSeconds_sum[0];
        RESULT1.best_resultSeconds[1] = RESULT1.best_resultSeconds_sum[1];
        RESULT1.best_resultSeconds[2] = RESULT1.best_resultSeconds_sum[2];
        RESULT1.best_resultSeconds[3] = RESULT1.best_resultSeconds_sum[3];
        RESULT1.best_resultSeconds[4] = RESULT1.best_resultSeconds_sum[4];

        RESULT1.best_playerName[0] = RESULT1.best_playerName_sum[0];
        RESULT1.best_playerName[1] = RESULT1.best_playerName_sum[1];
        RESULT1.best_playerName[2] = RESULT1.best_playerName_sum[2];
        RESULT1.best_playerName[3] = RESULT1.best_playerName_sum[3];
        RESULT1.best_playerName[4] = RESULT1.best_playerName_sum[4];


    }

    // Update is called once per frame
    void Update()
    {
        Text score_text1 = score_object1.GetComponent<Text>();
        Text score_text2 = score_object2.GetComponent<Text>();
        Text score_text3 = score_object3.GetComponent<Text>();
        Text score_text4 = score_object4.GetComponent<Text>();
        Text score_text5 = score_object5.GetComponent<Text>();
        score_text1.text = "1位    " + RESULT1.best_playerName[0] + "  " + RESULT1.best_result[0];
        score_text2.text = "2位    " + RESULT1.best_playerName[1] + "  " + RESULT1.best_result[1];
        score_text3.text = "3位    " + RESULT1.best_playerName[2] + "  " + RESULT1.best_result[2];
        score_text4.text = "4位    " + RESULT1.best_playerName[3] + "  " + RESULT1.best_result[3];
        score_text5.text = "5位    " + RESULT1.best_playerName[4] + "  " + RESULT1.best_result[4];




    }

}
