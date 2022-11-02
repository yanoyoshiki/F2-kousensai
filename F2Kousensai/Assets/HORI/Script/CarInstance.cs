using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInstance : MonoBehaviour
{

    float Player;
    float NPC;

    //プレイヤー１
    [SerializeField] GameObject Player1Prefab;
    public Transform P1InstancePoint;

    //プレイヤー２
    [SerializeField] GameObject Player2Prefab;
    public Transform P2InstancePoint;

    //プレイヤー３
    [SerializeField] GameObject Player3Prefab;
    public Transform P3InstancePoint;


    //プレイヤー４
    [SerializeField] GameObject Player4Prefab;
    public Transform P4InstancePoint;

    //NPC１
    [SerializeField] GameObject NPC1Prefab;
    public Transform N1InstancePoint;

    // Start is called before the first frame update
    void Start()
    {
        Player = DetermineNumber.Players; //プレイ人数
        NPC = DetermineNumber.NPC; //CPUの数
        Debug.Log(Player);
        Debug.Log(NPC);
        PlayerInstance(Player,NPC);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayerInstance(float P, float N) //プレイヤーとNPC生成、NPCは場合によっては元から配置して指定数までDestroyする処理に変えるかも
    {
        if (P >= 1)
        {
            //プレイヤー１生成処理
            float x = P1InstancePoint.position.x;
            float y = P1InstancePoint.position.y;
            float z = P1InstancePoint.position.z;
            Vector3 point1 = new Vector3(x, y, z);
            Quaternion myRotation = P1InstancePoint.rotation;
            Instantiate(Player1Prefab, point1, myRotation);
        }
        if (P >= 2)
        {
            //プレイヤー2生成処理
            float x = P2InstancePoint.position.x;
            float y = P2InstancePoint.position.y;
            float z = P2InstancePoint.position.z;
            Vector3 point2 = new Vector3(x, y, z);
            Quaternion myRotation = P2InstancePoint.rotation;
            Instantiate(Player2Prefab, point2, myRotation);
        }
        if (P >= 3)
        {
            //プレイヤー3生成処理
            float x = P3InstancePoint.position.x;
            float y = P3InstancePoint.position.y;
            float z = P3InstancePoint.position.z;
            Vector3 point3 = new Vector3(x, y, z);
            Quaternion myRotation = P1InstancePoint.rotation;
            Instantiate(Player3Prefab, point3, myRotation);
        }
        if (P >= 4)
        {
            //プレイヤー4生成処理
            float x = P4InstancePoint.position.x;
            float y = P4InstancePoint.position.y;
            float z = P4InstancePoint.position.z;
            Vector3 point4 = new Vector3(x, y, z);
            Quaternion myRotation = P1InstancePoint.rotation;
            Instantiate(Player4Prefab, point4, myRotation);
        }

        if (N >= 1)
        {
            //NPC１生成処理
            float x = N1InstancePoint.position.x;
            float y = N1InstancePoint.position.y;
            float z = N1InstancePoint.position.z;
            Vector3 pointN1 = new Vector3(x, y, z);
            Quaternion myRotation = N1InstancePoint.rotation;
            Instantiate(NPC1Prefab, pointN1, myRotation);
        }
        if (N >= 2)
        {
            //NPC2生成処理
        }
        if (N >= 3)
        {
            //NPC3生成処理
        }
        if (N >= 4)
        {
            //NPC4生成処理
        }

        
    }
}
