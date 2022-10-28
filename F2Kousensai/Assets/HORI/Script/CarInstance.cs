using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInstance : MonoBehaviour
{

    float Player;
    float NPC;

    [SerializeField] GameObject Player1Prefab;
    public Transform P1InstancePoint;

    // Start is called before the first frame update
    void Start()
    {
        Player = DetermineNumber.Players;
        NPC = DetermineNumber.NPC;
        Debug.Log(Player);
        Debug.Log(NPC);
        float x = P1InstancePoint.position.x;
        float y = P1InstancePoint.position.y;
        float z = P1InstancePoint.position.z;
        Vector3 point1 = new Vector3(x, y, z);
        Quaternion myRotation = P1InstancePoint.rotation;
        Instantiate(Player1Prefab, point1, myRotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
