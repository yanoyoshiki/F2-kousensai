using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car2 : MonoBehaviour
{
    //�������Ă���`�F�b�N�|�C���g
    CheckPoint nowCheckPoint;

    //�N���A�����`�F�b�N�|�C���g��
    int _checkCount;
    public int checkCount => _checkCount;

    //UI�\��
   // [SerializeField]
    //GameObject wrongWay;

    [SerializeField]
    public Text rank;

    public float ranknum;

    float speed;

    static public bool revertFlag;

    Vector3 p0;

    void Awake()
    {
        nowCheckPoint = CheckPoint.StartPoint;
        transform.position = nowCheckPoint.transform.position;
    }

    void Start()
    {
      p0 = transform.position;
    }

    void Update()
    {
        var p1 = transform.position; //�����̈ʒu
        var v = nowCheckPoint.nextCheckPoint.transform.position - transform.position;
        v.y = 0;

        if (nowCheckPoint.CheckWrongWay(p0, p1))
        {
            //�t��
            //wrongWay.SetActive(true);
        }
        else
        {
            //�t�����ĂȂ�
            //wrongWay.SetActive(false);
        }

        if (nowCheckPoint.CheckIfPassed(p0, p1))
        {
            //�`�F�b�N�|�C���g�ʉ�
            nowCheckPoint = nowCheckPoint.nextCheckPoint;
            _checkCount++;
        }
        p0 = p1; //p0�͑O�t���[���̈ʒu

    }

    //���̃`�F�b�N�|�C���g�ɂ�����i�s�x
    public float progress => nowCheckPoint.GetProgress(transform.position);

    public void SetRank(int rank)
    {
        this.rank.text = $"{rank + 1}��";
        ranknumSave(rank);
    }

    void ranknumSave(int num)
    {
        ranknum = num;
    }
}
