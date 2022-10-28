using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    float lap = 0; //���݂̎���
    float road = 0; //�`�F�b�N�|�C���g��ʉ߂�����

    public GameObject LapObject;

    float time = 0;

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

    // Start is called before the first frame update
    void Start()
    {
        minute = 0;
        seconds = 0f;
        oldSeconds = 0f;
        Lapminute = 0;
        Lapseconds = 0;
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
    public void RaceStart()
    {
        start = true;
    }

    void timer()
    {
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
            Lapseconds = seconds - 60;
        }

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
        Text lap_text = LapObject.GetComponent<Text>();
        if (lap == 0)
        {
            Debug.Log("�����");
            lap++;
            lap_text.text = "1/3";
        }
        else if (lap == 1 && road == 1)
        {
            Debug.Log("�����");
            lap++;
            lap_text.text = "2/3";
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
            
        }
        //�����ڂ����Ǘ�
    }
}
