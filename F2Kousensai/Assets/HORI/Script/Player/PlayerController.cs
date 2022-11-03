using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    static public float lap = 0; //現在の周回数
    static public float road = 0; //チェックポイントを通過したか

    [SerializeField]
    public Text lap_text;

    //public GameObject LapTextObject = null; // Textオブジェクト

    float time = 0;
    public static PlayerController instance;

    public ShowGoal goal;

    bool start = false;

    string Lap1Text = "Lap1	";
    string Lap2Text = "Lap2	";
    string Lap3Text = "Lap3	";
    string TotalText = "total		";

    [SerializeField]
    private int minute;
    [SerializeField]
    private int Lapminute;
    [SerializeField]
    private float seconds;
    [SerializeField]
    private float Lapseconds;
    //　前のUpdateの時の秒数
    private float oldSeconds;
    //　タイマー表示用テキスト
    [SerializeField]
    private Text TimeText01 = null;
    [SerializeField]
    private Text TimeText02 = null;
    [SerializeField]
    private Text TimeText03 = null;
    [SerializeField]
    private Text TotalTimeText = null;

    float flag12 = 1;
    float flag23 = 1;

    private IEnumerator Inoperable(float i) // 操作を不能にする（引数の秒数間）
    {
        Debug.Log("Y");
        PlayerController inputScript = this;
        inputScript.enabled = false; // スクリプトを無効化
        yield return new WaitForSeconds(i); // 引数の秒数だけ待つ
        inputScript.enabled = true; // スクリプトを有効化
        yield break;
    }

    // Start is called before the first frame update
    void Start()
    {
        minute = 0;
        seconds = 0f;
        oldSeconds = 0f;
        Lapminute = 0;
        Lapseconds = 0;
        //this.lap_text = GameObject.Find("LapNumberText").GetComponent<Text>();
        StartCoroutine("Inoperable", 5f); // ５秒処理停止
    }

    // Update is called once per frame
    void Update()
    {
        //if (start)
        //{
        //timer();
        //}

        seconds += Time.deltaTime;
        if (seconds >= 60f)
        {
            minute++;
            seconds = seconds - 60;
        }

        Lapseconds += Time.deltaTime;
        if (Lapseconds >= 60f)
        {
            Lapminute++;
            Lapseconds = Lapseconds - 60;
        }
        if (lap != 4)
        {
            TotalTimeText.text = TotalText + minute.ToString("00") + ":" + ((int)seconds).ToString("00");

        }

        if (lap == 0 || lap == 1)
        {
            TimeText01.text = Lap1Text + minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        }
        else if (lap == 2)
        {
            if (flag12 == 1)
            {
                Lapseconds = 0;
                Lapminute = 0;
                flag12 = 0;
            }
            TimeText02.text = Lap2Text + Lapminute.ToString("00") + ":" + ((int)Lapseconds).ToString("00");
        }
        else if (lap == 3)
        {
            if (flag23 == 1)
            {
                Lapseconds = 0;
                Lapminute = 0;
                flag23 = 0;
            }
            TimeText03.text = Lap3Text + Lapminute.ToString("00") + ":" + ((int)Lapseconds).ToString("00");
        }

    }

    public void RoadNum()
    {
        Debug.Log("road:" + road);
        if (road == 0)
        {
            Debug.Log("一周目チェックポイント");
            road++;
            
        }
        else if (road == 1)
        {
            Debug.Log("二周目チェックポイント");
            road++;
        }
        else if (road == 2)
        {
            Debug.Log("三周目チェックポイント");
            road++;
        }
    }

    public void LapNum()
    {
        //Text lap_text = LapTextObject.GetComponent<Text>();
        Debug.Log("lap:"+lap);
        if (lap == 0)
        {
            Debug.Log("一周目");
            lap++;
            lap_text.text = "1/3";
            Debug.Log(lap);
            Debug.Log(road);
        }
        else if (lap == 1 && road == 1)
        {
            Debug.Log("二周目");
            lap++;
            lap_text.text = "2/3";
            Debug.Log(lap);
            Debug.Log(road);
        }
        else if (lap == 2 && road == 2)
        {
            Debug.Log("三周目");
            lap++;
            lap_text.text = "3/3";
        }
        else if (lap == 3 && road == 3)
        {
            Debug.Log("ゴール");
            lap++;
            //関数呼び出してゴール表記を作る
            goal.goalcheck();
            Stop();
        }
        //何周目かを管理
    }

    void Stop()
    {
        //ゴール時点での記録を保存して関数で別に渡してまとめてもらう
        string TimeRecord = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        float rank = this.GetComponent<Car2>().ranknum;
        float playernumber = 1; //割り当てるプレイヤーごとに１～４で変更する
        float S = minute * 60 + seconds;
        GameObject goalscript = GameObject.FindWithTag("Goal");
        goalscript.GetComponent<Goal>().record(playernumber,rank,TimeRecord,S);
        StartCoroutine("Inoperable", 2f); // 2秒処理停止
        //邪魔にならないように車を消すか移動させる処理をここに

    }

    /*
    １位　プレイヤー２　タイム
    ３位　プレイヤー４　タイム
    ４位　プレイヤー１　タイム
    ７位　プレイヤー３　タイム

     */


}
