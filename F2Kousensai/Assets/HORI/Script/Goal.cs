using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    //�^�C���L�^
    public static string Player1Time;
    public static string Player2Time;
    public static string Player3Time;
    public static string Player4Time;

    //���ʋL�^
    public static float Player1Rank;
    public static float Player2Rank;
    public static float Player3Rank;
    public static float Player4Rank;

    //�^�C���L�^�\�[�g�p
    public static float Player1TimeSeconds;
    public static float Player2TimeSeconds;
    public static float Player3TimeSeconds;
    public static float Player4TimeSeconds;

    float Resultcount=0;
    private float PlayerNumber;

    // Start is called before the first frame update
    void Start()
    {
        PlayerNumber = DetermineNumber.Players; //�Q���v���C���[�̑������擾
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void record(float num,float rank,string time,float timeSeconds) //�O���珇�ɁA�v���C���[�ԍ��A�S�[�����̏��ʁA�^�C��
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
            SceneManager.LoadScene("���U���g��ʂ̃V�[����"); //�S�v���C���[�̋L�^������������V�[���J��
        }
    }
}
