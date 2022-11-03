using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    //タイム記録
    public static string Player1Time;
    public static string Player2Time;
    public static string Player3Time;
    public static string Player4Time;

    //順位記録
    public static float Player1Rank;
    public static float Player2Rank;
    public static float Player3Rank;
    public static float Player4Rank;

    //タイム記録ソート用
    public static float Player1TimeSeconds;
    public static float Player2TimeSeconds;
    public static float Player3TimeSeconds;
    public static float Player4TimeSeconds;

    float Resultcount=0;
    private float PlayerNumber;

    // Start is called before the first frame update
    void Start()
    {
        PlayerNumber = DetermineNumber.Players; //参加プレイヤーの総数を取得
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void record(float num,float rank,string time,float timeSeconds) //前から順に、プレイヤー番号、ゴール時の順位、タイム
    {
        if (num == 1)
        {
            Player1Rank = rank;
            Player1Time = time;
            Player1TimeSeconds = timeSeconds;
            Resultcount++;
        }
        else if (num == 2)
        {
            Player2Rank = rank;
            Player2Time = time;
            Player2TimeSeconds = timeSeconds;
            Resultcount++;
        }
        else if (num == 3)
        {
            Player3Rank = rank;
            Player3Time = time;
            Player3TimeSeconds = timeSeconds;
            Resultcount++;
        }
        else if (num == 4)
        {
            Player4Rank = rank;
            Player4Time = time;
            Player4TimeSeconds = timeSeconds;
            Resultcount++;

        }
        if (Resultcount == PlayerNumber)
        {
            SceneManager.LoadScene("リザルト画面のシーン名"); //全プレイヤーの記録が完了したらシーン遷移
        }
    }
}
