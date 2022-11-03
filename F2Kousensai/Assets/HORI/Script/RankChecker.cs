using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class RankChecker : MonoBehaviour
{
    List<Car2> carList = new List<Car2>();

    int phase = 0;


    float count = 1;

    float Ncount = 0;

    GameObject A;

    //プレイヤー１から４
    [SerializeField]
    GameObject car1Prefab;
    [SerializeField]
    GameObject car2Prefab;
    [SerializeField]
    GameObject car3Prefab;
    [SerializeField]
    GameObject car4Prefab;

    public Transform P1InstancePoint;
    public Transform P2InstancePoint;
    public Transform P3InstancePoint;
    public Transform P4InstancePoint;

    //NPC１から４
    /*[SerializeField]
    GameObject carNPC1;
    [SerializeField]
    GameObject carNPC2;
    [SerializeField]
    GameObject carNPC3;
    [SerializeField]
    GameObject carNPC4;*/

    //[SerializeField]
    //Camera closeUpCamera;

    void Start()
    {
        count = DetermineNumber.Players; //プレイ人数
        Ncount = DetermineNumber.NPC; //CPUの数
        Debug.Log(count);
        Debug.Log(Ncount);
    }

    void Update()
    {
        if (phase == 0) //ゲーム開始時の処理
        {
            CheckPoint.SetForward();

            Car2 car;
            if (count >= 1)
            {
                car = Instantiate<GameObject>(car1Prefab).GetComponent<Car2>(); //プレイヤー１生成
                //生成したプレイヤー１をタグで取得して、transformで所定の位置に移動
                float x = P1InstancePoint.position.x;
                float y = P1InstancePoint.position.y;
                float z = P1InstancePoint.position.z;
                Vector3 point1 = new Vector3(x, y, z);
                Quaternion myRotation = P1InstancePoint.rotation;
                A = GameObject.FindWithTag("Player1");
                A.transform.position = point1;
                A.transform.rotation = myRotation;

                carList.Add(car); //順位を確認するためのリストに生成した車を放りこんでる
            }
            if (count >= 2)
            {
                car = Instantiate<GameObject>(car2Prefab).GetComponent<Car2>(); //プレイヤー2生成
                //生成したプレイヤー2をタグで取得して、transformで所定の位置に移動
                float x = P2InstancePoint.position.x;
                float y = P2InstancePoint.position.y;
                float z = P2InstancePoint.position.z;
                Vector3 point2 = new Vector3(x, y, z);
                Quaternion myRotation = P2InstancePoint.rotation;
                A = GameObject.FindWithTag("Player2");
                A.transform.position = point2;
                A.transform.rotation = myRotation;

                carList.Add(car); //順位を確認するためのリストに生成した車を放りこんでる
            }
            if (count >= 3)
            {
                car = Instantiate<GameObject>(car3Prefab).GetComponent<Car2>(); //プレイヤー3生成
                //生成したプレイヤー3をタグで取得して、transformで所定の位置に移動
                float x = P3InstancePoint.position.x;
                float y = P3InstancePoint.position.y;
                float z = P3InstancePoint.position.z;
                Vector3 point3 = new Vector3(x, y, z);
                Quaternion myRotation = P3InstancePoint.rotation;
                A = GameObject.FindWithTag("Player3");
                A.transform.position = point3;
                A.transform.rotation = myRotation;

                carList.Add(car); //順位を確認するためのリストに生成した車を放りこんでる
            }
            if (count >= 4)
            {
                car = Instantiate<GameObject>(car4Prefab).GetComponent<Car2>(); //プレイヤー4生成
                //生成したプレイヤー3をタグで取得して、transformで所定の位置に移動
                float x = P4InstancePoint.position.x;
                float y = P4InstancePoint.position.y;
                float z = P4InstancePoint.position.z;
                Vector3 point4 = new Vector3(x, y, z);
                Quaternion myRotation = P4InstancePoint.rotation;
                A = GameObject.FindWithTag("Player4");
                A.transform.position = point4;
                A.transform.rotation = myRotation;
                carList.Add(car); //順位を確認するためのリストに生成した車を放りこんでる
            }

            if (Ncount >= 1)
            {
                //car = Instantiate<GameObject>(carNPC1).GetComponent<Car2>(); //NPC１生成
                //car = GameObject.FindWithTag("NPC1").GetComponent<Car2>(); //すでに場にあるNPC1を取得 どっちかを使う
                 //生成したプレイヤー１をタグで取得して、transformで所定の位置に移動
                //carList.Add(car); //順位を確認するためのリストに生成した車を放りこんでる
            }
            if (Ncount >= 2)
            {
                
            }
            if (Ncount >= 3)
            {
               
            }
            if (Ncount >= 4)
            {
                
            }

            phase = 1;
            Debug.Log("phase:"+phase);
        }
        else if (phase == 1)
        {
            //レース中
        }
    }

    private void LateUpdate()
    {
        if (phase == 1)
        {
            //チェックポイント通過数が多い方が上(降順)
            //通過数が同じ場合は、進行度が大きいの方が上(降順)
            var order = carList.OrderByDescending(c => c.checkCount).ThenByDescending(c => c.progress);
            int rank = 0;

            foreach (var car in order)
            {
                car.SetRank(rank++);
            }

            
        }
    }
}
