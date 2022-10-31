using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartScript : MonoBehaviour
{
    public Text CountDownText;
    public static float CountDownTime; // カウントダウンタイム
    float go = 0;
    float goal = 0;

    private IEnumerator Inoperable(float i) // 操作を不能にする（引数の秒数間）
    {
        Debug.Log("Z");
        GameStartScript inputScript = this;
        CountDownText.text = "GO!";
        yield return new WaitForSeconds(i); // 引数の秒数だけ待つ
        CountDownText.text = "";
        yield break;
    }

    // Start is called before the first frame update
    void Start()
    {
        CountDownTime = 5f;    // カウントダウン開始秒数をセット
    }

    // Update is called once per frame
    void Update()
    {
        // カウントダウンタイムを整形して表示
        if (CountDownTime > 0)
        {
            CountDownText.text = CountDownTime.ToString("0");
        }

        if (CountDownTime <= 0 && go==0)
        {
            StartCoroutine("Inoperable", 2f); // 2秒処理停止
            go++;
        }
        else if(CountDownTime>0)
        {
            // 経過時刻を引いていく
            CountDownTime -= Time.deltaTime;
        }

       
        
    }

   

}
