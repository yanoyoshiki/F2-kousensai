using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RESULT1 : MonoBehaviour
{
    public GameObject score_object1 = null; // Textオブジェクト
    public GameObject score_object2 = null; // Textオブジェクト
    public GameObject score_object3 = null; // Textオブジェクト
    public GameObject score_object4 = null; // Textオブジェクト

    public GameObject best_star1 = null;
    public GameObject best_star2 = null;
    public GameObject best_star3 = null;
    public GameObject best_star4 = null;


    string[] result = new string[4];
    int[] playerNO = new int[4] {1,2,3,4};
    int[] player_rank = new int[4];
    int[] resultSeconds = new int[4];
    int player_count;
    public static int[] star_flag = new int[4]; //上位ランキング入りのフラグ

    public static string[] best_result = new string[5];
    public static int[] best_resultSeconds = new int[5];
    public static string[] best_playerName = new string[5];

    public static string[] best_result_sum = new string[9];
    public static int[] best_resultSeconds_sum = new int[9];
    public static string[] best_playerName_sum = new string[9];




    // Start is called before the first frame update
    void Start()
    {
        
        int i, j;
        string time_tmp;
        int NO_tmp;
        int player_rank_tmp;
        int sec_tmp;
        
        star_flag[0] = 0;
        star_flag[1] = 0;
        star_flag[2] = 0;
        star_flag[3] = 0;
        

        number_insert(); // ホリへ　記録はここに代入してくれ


        for (i = 0; i < player_count; ++i)
        {
            for (j = i + 1; j < player_count; ++j)
            {
                if (player_rank[i] > player_rank[j])
                {

                    player_rank_tmp = player_rank[i];
                    player_rank[i] = player_rank[j];
                    player_rank[j] = player_rank_tmp;


                    time_tmp = result[i];
                    result[i] = result[j];
                    result[j] = time_tmp;

                    NO_tmp = playerNO[i];
                    playerNO[i] = playerNO[j];
                    playerNO[j] = NO_tmp;

                    sec_tmp = resultSeconds[i];
                    resultSeconds[i] = resultSeconds[j];
                    resultSeconds[j] = sec_tmp;



                }
            }
        }


        best_result_sum[0] = best_result[0];
        best_result_sum[1] = best_result[1];
        best_result_sum[2] = best_result[2];
        best_result_sum[3] = best_result[3];
        best_result_sum[4] = best_result[4];
        best_result_sum[5] = result[0];
        best_result_sum[6] = result[1];
        best_result_sum[7] = result[2];
        best_result_sum[8] = result[3];

        best_resultSeconds_sum[0] = best_resultSeconds[0];
        best_resultSeconds_sum[1] = best_resultSeconds[1];
        best_resultSeconds_sum[2] = best_resultSeconds[2];
        best_resultSeconds_sum[3] = best_resultSeconds[3];
        best_resultSeconds_sum[4] = best_resultSeconds[4];
        best_resultSeconds_sum[5] = resultSeconds[0];
        best_resultSeconds_sum[6] = resultSeconds[1];
        best_resultSeconds_sum[7] = resultSeconds[2];
        best_resultSeconds_sum[8] = resultSeconds[3];

        best_playerName_sum[0] = best_playerName[0];
        best_playerName_sum[1] = best_playerName[1];
        best_playerName_sum[2] = best_playerName[2];
        best_playerName_sum[3] = best_playerName[3];
        best_playerName_sum[4] = best_playerName[4];




        if (best_resultSeconds[4] > resultSeconds[0])
        {
            star_flag[0] = 1;
        }
        if (best_resultSeconds[3] > resultSeconds[1])
        {
            star_flag[1] = 1;
        }
        if (best_resultSeconds[2] > resultSeconds[2])
        {
            star_flag[2] = 1;
        }
        if (best_resultSeconds[1] > resultSeconds[3])
        {
            star_flag[3] = 1;
        }
        if (star_flag[0] == 0 && star_flag[1] == 0 && star_flag[2] == 0 && star_flag[3] == 0)
        {
            Invoke("NextScene", 8.0f);　// 8秒後に実行
        }

        if (star_flag[0] == 1)
        {
            Invoke("player1_insert_name_Scene", 8.0f);　// 8秒後に実行
            Debug.Log("if (star_flag[0] == 1){Invoke(player1_insert_name_Scene, 2.0f); ");   
        }
        /*else
        if (star_flag[1] == 1)
        {
            Invoke("player2_insert_name_Scene", 8.0f); // 8秒後に実行
            Debug.Log("if (star_flag[1] == 1){Invoke(player2_insert_name_Scene, 2.0f); ");

        }else
        if (star_flag[2] == 1)
        {
            Invoke("player3_insert_name_Scene", 8.0f); // 8秒後に実行
            Debug.Log("if (star_flag[2] == 1){Invoke(player3_insert_name_Scene, 2.0f); ");

        }else
        if (star_flag[3] == 1)
        {
            Invoke("player4_insert_name_Scene", 8.0f); // 8秒後に実行
            Debug.Log("if (star_flag[3] == 1){Invoke(player4_insert_name_Scene, 2.0f); ");

        }*/






    }

    // Update is called once per frame
    void Update()
    {

        if(player_count== 4)
        {
            Text score_text1 = score_object1.GetComponent<Text>();
            Text score_text2 = score_object2.GetComponent<Text>();
            Text score_text3 = score_object3.GetComponent<Text>();
            Text score_text4 = score_object4.GetComponent<Text>();
            Text best_star_text1 = best_star1.GetComponent<Text>();
            Text best_star_text2 = best_star2.GetComponent<Text>();
            Text best_star_text3 = best_star3.GetComponent<Text>();
            Text best_star_text4 = best_star4.GetComponent<Text>();
            score_text1.text = player_rank[0].ToString() + "位    Player  " + playerNO[0].ToString() + "  " + result[0];
            score_text2.text = player_rank[1].ToString() + "位    Player  " + playerNO[1].ToString() + "  " + result[1];
            score_text3.text = player_rank[2].ToString() + "位    Player  " + playerNO[2].ToString() + "  " + result[2];
            score_text4.text = player_rank[3].ToString() + "位    Player  " + playerNO[3].ToString() + "  " + result[3];
            if(star_flag[0] == 1)
            {
                best_star_text1.text = "★";
            }
            if (star_flag[1] == 1)
            {
                best_star_text2.text = "★";
            }
            if (star_flag[2] == 1)
            {
                best_star_text3.text = "★";
            }
            if (star_flag[3] == 1)
            {
                best_star_text4.text = "★";
            }



        }
        else
        if (player_count == 3)
        {
            Text score_text1 = score_object1.GetComponent<Text>();
            Text score_text2 = score_object2.GetComponent<Text>();
            Text score_text3 = score_object3.GetComponent<Text>();
            Text best_star_text1 = best_star1.GetComponent<Text>();
            Text best_star_text2 = best_star2.GetComponent<Text>();
            Text best_star_text3 = best_star3.GetComponent<Text>();
            score_text1.text = player_rank[0].ToString() + "位    Player  " + playerNO[0].ToString() + "  " + result[0];
            score_text2.text = player_rank[1].ToString() + "位    Player  " + playerNO[1].ToString() + "  " + result[1];
            score_text3.text = player_rank[2].ToString() + "位    Player  " + playerNO[2].ToString() + "  " + result[2];

            if (star_flag[0] == 1)
            {
                best_star_text1.text = "★";
            }
            if (star_flag[1] == 1)
            {
                best_star_text2.text = "★";
            }
            if (star_flag[2] == 1)
            {
                best_star_text3.text = "★";
            }

        }
        else 
        if (player_count == 2)
        {
            Text score_text1 = score_object1.GetComponent<Text>();
            Text score_text2 = score_object2.GetComponent<Text>();
            Text best_star_text1 = best_star1.GetComponent<Text>();
            Text best_star_text2 = best_star2.GetComponent<Text>();
            score_text1.text = player_rank[0].ToString() + "位    Player  " + playerNO[0].ToString() + "  " + result[0];
            score_text2.text = player_rank[1].ToString() + "位    Player  " + playerNO[1].ToString() + "  " + result[1];

            if (star_flag[0] == 1)
            {
                best_star_text1.text = "★";
            }
            if (star_flag[1] == 1)
            {
                best_star_text2.text = "★";
            }


        }
        else 
        if (player_count == 1)
        {
            Text score_text1 = score_object1.GetComponent<Text>();
            Text best_star_text1 = best_star1.GetComponent<Text>();
            score_text1.text = player_rank[0].ToString() + "位    Player  " + playerNO[0].ToString() + "  " + result[0];

            if (star_flag[0] == 1)
            {
                best_star_text1.text = "★";
            }


        }



    }

    void number_insert()
    {
        string tmps;
        int tmp;
        int i, j;

        
        /* ホリの作ったプレイヤーのタイムとランク取得
        result[0] = Goal.Player1Time;
        result[1] = Goal.Player2Time;
        result[2] = Goal.Player3Time;
        result[3] = Goal.Player4Time;

        resultSeconds[0] = Goal.Player1timeSeconds;
        resultSeconds[1] = Goal.Player2timeSeconds;
        resultSeconds[2] = Goal.Player3timeSeconds;
        resultSeconds[3] = Goal.Player4timeSeconds;

        player_rank[0] = Goal.Player1Rank;
        player_rank[1] = Goal.Player2Rank;
        player_rank[2] = Goal.Player3Rank;
        player_rank[3] = Goal.Player4Rank;

        player_count = aaaaa.playercount;

        */

        result[0] = "01:02";//テストタイム
        result[1] = "00:45";
        result[2] = "00:25";
        result[3] = "00:34";

        resultSeconds[0] = 62;
        resultSeconds[1] = 45;
        resultSeconds[2] = 25;
        resultSeconds[3] = 34;

        player_rank[0] = 8;//テスト順位
        player_rank[1] = 6;//テスト順位
        player_rank[2] = 1;//テスト順位
        player_rank[3] = 3;//テスト順位

        player_count = 4; // 4人と仮定

        /*
                
        */

        
        //-------------------------------------------

        best_result[0] = "00:27";//テストタイム
        best_result[1] = "00:29";
        best_result[2] = "00:33";
        best_result[3] = "00:35";
        best_result[4] = "00:40";


        best_resultSeconds[0] = 27;
        best_resultSeconds[1] = 29;
        best_resultSeconds[2] = 33;
        best_resultSeconds[3] = 35;
        best_resultSeconds[4] = 40;

        best_playerName[0] = "うんこ1";
        best_playerName[1] = "うんこ2";
        best_playerName[2] = "うんこ3";
        best_playerName[3] = "うんこ4";
        best_playerName[4] = "うんこ5";


        




    }

    void player1_insert_name_Scene()
    {
        SceneManager.LoadScene("player1_insert_name");
    }
    void player2_insert_name_Scene()
    {
        SceneManager.LoadScene("player2_insert_name");
    }
    void player3_insert_name_Scene()
    {
        SceneManager.LoadScene("player3_insert_name");
    }
    void player4_insert_name_Scene()
    {
        SceneManager.LoadScene("player4_insert_name");
    }

    void NextScene()
    {
        SceneManager.LoadScene("Best_time");
    }
}
