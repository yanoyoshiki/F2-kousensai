using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    static public float lap = 0; //���݂̎���
    static public float road = 0; //�`�F�b�N�|�C���g��ʉ߂�����

    [SerializeField]
    public Text lap_text;

    //public GameObject LapTextObject = null; // Text�I�u�W�F�N�g

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
    //�@�O��Update�̎��̕b��
    private float oldSeconds;
    //�@�^�C�}�[�\���p�e�L�X�g
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

    private IEnumerator Inoperable(float i) // �����s�\�ɂ���i�����̕b���ԁj
    {
        Debug.Log("Y");
        PlayerController inputScript = this;
        inputScript.enabled = false; // �X�N���v�g�𖳌���
        yield return new WaitForSeconds(i); // �����̕b�������҂�
        inputScript.enabled = true; // �X�N���v�g��L����
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
        StartCoroutine("Inoperable", 5f); // �T�b������~
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
            Debug.Log("����ڃ`�F�b�N�|�C���g");
            road++;
            
        }
        else if (road == 1)
        {
            Debug.Log("����ڃ`�F�b�N�|�C���g");
            road++;
        }
        else if (road == 2)
        {
            Debug.Log("�O���ڃ`�F�b�N�|�C���g");
            road++;
        }
    }

    public void LapNum()
    {
        //Text lap_text = LapTextObject.GetComponent<Text>();
        Debug.Log("lap:"+lap);
        if (lap == 0)
        {
            Debug.Log("�����");
            lap++;
            lap_text.text = "1/3";
            Debug.Log(lap);
            Debug.Log(road);
        }
        else if (lap == 1 && road == 1)
        {
            Debug.Log("�����");
            lap++;
            lap_text.text = "2/3";
            Debug.Log(lap);
            Debug.Log(road);
        }
        else if (lap == 2 && road == 2)
        {
            Debug.Log("�O����");
            lap++;
            lap_text.text = "3/3";
        }
        else if (lap == 3 && road == 3)
        {
            Debug.Log("�S�[��");
            lap++;
            //�֐��Ăяo���ăS�[���\�L�����
            goal.goalcheck();
            Stop();
        }
        //�����ڂ����Ǘ�
    }

    void Stop()
    {
        //�S�[�����_�ł̋L�^��ۑ����Ċ֐��ŕʂɓn���Ă܂Ƃ߂Ă��炤
        string TimeRecord = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        float rank = this.GetComponent<Car2>().ranknum;
        float playernumber = 1; //���蓖�Ă�v���C���[���ƂɂP�`�S�ŕύX����
        float S = minute * 60 + seconds;
        GameObject goalscript = GameObject.FindWithTag("Goal");
        goalscript.GetComponent<Goal>().record(playernumber,rank,TimeRecord,S);
        StartCoroutine("Inoperable", 2f); // 2�b������~
        //�ז��ɂȂ�Ȃ��悤�ɎԂ��������ړ������鏈����������

    }

    /*
    �P�ʁ@�v���C���[�Q�@�^�C��
    �R�ʁ@�v���C���[�S�@�^�C��
    �S�ʁ@�v���C���[�P�@�^�C��
    �V�ʁ@�v���C���[�R�@�^�C��

     */


}
