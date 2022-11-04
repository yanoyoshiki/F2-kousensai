using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class InputFieldManager3 : MonoBehaviour
{
    //出力用のテキスト
    public Text displayText;

    //inputFieldのOnEndEditに設定する用の関数
    public void OnEndEdit()
    {
        //InputFieldコンポーネントのtextを変数に代入
        string inputFieldText = GetComponent<InputField>().text;

        //出力用のテキストに代入
        displayText.text = inputFieldText;



    }
    public void name_insert()
    {
        string inputFieldText = GetComponent<InputField>().text;
        RESULT1.best_playerName_sum[7] = inputFieldText;


        if (RESULT1.star_flag[3] == 1)
        {
            SceneManager.LoadScene("player4_insert_name");
        }
        else
        {
            SceneManager.LoadScene("Best_time");
        }
    }
}