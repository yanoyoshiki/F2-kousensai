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

    //�v���C���[�P����S
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

    //NPC�P����S
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
        count = DetermineNumber.Players; //�v���C�l��
        Ncount = DetermineNumber.NPC; //CPU�̐�
        Debug.Log(count);
        Debug.Log(Ncount);
    }

    void Update()
    {
        if (phase == 0) //�Q�[���J�n���̏���
        {
            CheckPoint.SetForward();

            Car2 car;
            if (count >= 1)
            {
                car = Instantiate<GameObject>(car1Prefab).GetComponent<Car2>(); //�v���C���[�P����
                //���������v���C���[�P���^�O�Ŏ擾���āAtransform�ŏ���̈ʒu�Ɉړ�
                float x = P1InstancePoint.position.x;
                float y = P1InstancePoint.position.y;
                float z = P1InstancePoint.position.z;
                Vector3 point1 = new Vector3(x, y, z);
                Quaternion myRotation = P1InstancePoint.rotation;
                A = GameObject.FindWithTag("Player1");
                A.transform.position = point1;
                A.transform.rotation = myRotation;

                carList.Add(car); //���ʂ��m�F���邽�߂̃��X�g�ɐ��������Ԃ���肱��ł�
            }
            if (count >= 2)
            {
                car = Instantiate<GameObject>(car2Prefab).GetComponent<Car2>(); //�v���C���[2����
                //���������v���C���[2���^�O�Ŏ擾���āAtransform�ŏ���̈ʒu�Ɉړ�
                float x = P2InstancePoint.position.x;
                float y = P2InstancePoint.position.y;
                float z = P2InstancePoint.position.z;
                Vector3 point2 = new Vector3(x, y, z);
                Quaternion myRotation = P2InstancePoint.rotation;
                A = GameObject.FindWithTag("Player2");
                A.transform.position = point2;
                A.transform.rotation = myRotation;

                carList.Add(car); //���ʂ��m�F���邽�߂̃��X�g�ɐ��������Ԃ���肱��ł�
            }
            if (count >= 3)
            {
                car = Instantiate<GameObject>(car3Prefab).GetComponent<Car2>(); //�v���C���[3����
                //���������v���C���[3���^�O�Ŏ擾���āAtransform�ŏ���̈ʒu�Ɉړ�
                float x = P3InstancePoint.position.x;
                float y = P3InstancePoint.position.y;
                float z = P3InstancePoint.position.z;
                Vector3 point3 = new Vector3(x, y, z);
                Quaternion myRotation = P3InstancePoint.rotation;
                A = GameObject.FindWithTag("Player3");
                A.transform.position = point3;
                A.transform.rotation = myRotation;

                carList.Add(car); //���ʂ��m�F���邽�߂̃��X�g�ɐ��������Ԃ���肱��ł�
            }
            if (count >= 4)
            {
                car = Instantiate<GameObject>(car4Prefab).GetComponent<Car2>(); //�v���C���[4����
                //���������v���C���[3���^�O�Ŏ擾���āAtransform�ŏ���̈ʒu�Ɉړ�
                float x = P4InstancePoint.position.x;
                float y = P4InstancePoint.position.y;
                float z = P4InstancePoint.position.z;
                Vector3 point4 = new Vector3(x, y, z);
                Quaternion myRotation = P4InstancePoint.rotation;
                A = GameObject.FindWithTag("Player4");
                A.transform.position = point4;
                A.transform.rotation = myRotation;
                carList.Add(car); //���ʂ��m�F���邽�߂̃��X�g�ɐ��������Ԃ���肱��ł�
            }

            if (Ncount >= 1)
            {
                //car = Instantiate<GameObject>(carNPC1).GetComponent<Car2>(); //NPC�P����
                //car = GameObject.FindWithTag("NPC1").GetComponent<Car2>(); //���łɏ�ɂ���NPC1���擾 �ǂ��������g��
                 //���������v���C���[�P���^�O�Ŏ擾���āAtransform�ŏ���̈ʒu�Ɉړ�
                //carList.Add(car); //���ʂ��m�F���邽�߂̃��X�g�ɐ��������Ԃ���肱��ł�
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
            //���[�X��
        }
    }

    private void LateUpdate()
    {
        if (phase == 1)
        {
            //�`�F�b�N�|�C���g�ʉߐ�������������(�~��)
            //�ʉߐ��������ꍇ�́A�i�s�x���傫���̕�����(�~��)
            var order = carList.OrderByDescending(c => c.checkCount).ThenByDescending(c => c.progress);
            int rank = 0;

            foreach (var car in order)
            {
                car.SetRank(rank++);
            }

            
        }
    }
}
