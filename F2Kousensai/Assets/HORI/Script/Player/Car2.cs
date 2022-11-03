using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car2 : MonoBehaviour
{
    //今走っているチェックポイント
    CheckPoint nowCheckPoint;

    //クリアしたチェックポイント数
    int _checkCount;
    public int checkCount => _checkCount;

    //UI表示
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
        var p1 = transform.position; //自分の位置
        var v = nowCheckPoint.nextCheckPoint.transform.position - transform.position;
        v.y = 0;

        if (nowCheckPoint.CheckWrongWay(p0, p1))
        {
            //逆走
            //wrongWay.SetActive(true);
        }
        else
        {
            //逆走してない
            //wrongWay.SetActive(false);
        }

        if (nowCheckPoint.CheckIfPassed(p0, p1))
        {
            //チェックポイント通過
            nowCheckPoint = nowCheckPoint.nextCheckPoint;
            _checkCount++;
        }
        p0 = p1; //p0は前フレームの位置

    }

    //そのチェックポイントにおける進行度
    public float progress => nowCheckPoint.GetProgress(transform.position);

    public void SetRank(int rank)
    {
        this.rank.text = $"{rank + 1}位";
        ranknumSave(rank);
    }

    void ranknumSave(int num)
    {
        ranknum = num;
    }
}
