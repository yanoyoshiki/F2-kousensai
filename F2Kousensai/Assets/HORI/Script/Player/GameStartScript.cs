using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartScript : MonoBehaviour
{
    public Text CountDownText;
    public static float CountDownTime; // �J�E���g�_�E���^�C��
    float go = 0;
    float goal = 0;

    private IEnumerator Inoperable(float i) // �����s�\�ɂ���i�����̕b���ԁj
    {
        Debug.Log("Z");
        GameStartScript inputScript = this;
        CountDownText.text = "GO!";
        yield return new WaitForSeconds(i); // �����̕b�������҂�
        CountDownText.text = "";
        yield break;
    }

    // Start is called before the first frame update
    void Start()
    {
        CountDownTime = 5f;    // �J�E���g�_�E���J�n�b�����Z�b�g
    }

    // Update is called once per frame
    void Update()
    {
        // �J�E���g�_�E���^�C���𐮌`���ĕ\��
        if (CountDownTime > 0)
        {
            CountDownText.text = CountDownTime.ToString("0");
        }

        if (CountDownTime <= 0 && go==0)
        {
            StartCoroutine("Inoperable", 2f); // 2�b������~
            go++;
        }
        else if(CountDownTime>0)
        {
            // �o�ߎ����������Ă���
            CountDownTime -= Time.deltaTime;
        }

       
        
    }

   

}
