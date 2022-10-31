using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class RankChecker : MonoBehaviour
{
    List<Car> carList = new List<Car>();

    int phase = 0;

    [SerializeField]
    int count = 4;

    [SerializeField]
    GameObject carPrefab;

    //[SerializeField]
    //Camera closeUpCamera;

    void Update()
    {
        if (phase == 0) //�Q�[���J�n���̏���
        {
            CheckPoint.SetForward();

            for (int i = 0; i < count; i++)
            {
                var car = Instantiate<GameObject>(carPrefab).GetComponent<Car>(); //�Ԑ����@�Ȃ��Ă�������

                carList.Add(car); //���ʂ��m�F���邽�߂̃��X�g�ɐ��������Ԃ���肱��ł�

            }
            phase = 1;
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

            //�N���[�Y�A�b�v�J����
            //closeUpCamera.transform.position = carList[0].transform.position - Camera.main.transform.forward * 8.0f;
            //closeUpCamera.transform.rotation = Camera.main.transform.rotation;
        }
    }

    /*private void OnGUI()
    {
        if (GUILayout.Button("�t��"))
        {
            Car.revertFlag = !Car.revertFlag;
        }
    }*/
}
