using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float lap = 0; //���݂̎���
    float road = 0; //�`�F�b�N�|�C���g��ʉ߂�����

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
        if (lap == 0)
        {
            Debug.Log("�����");
            lap++;
        }else if (lap == 1 && road == 1)
        {
            Debug.Log("�����");
            lap++;
        }else if (lap == 2 && road == 2)
        {
            Debug.Log("�O����");
            lap++;
        }else if (lap == 3 && road == 3)
        {
            Debug.Log("�S�[��");
            lap++;
        }
        //�����ڂ����Ǘ�
    }
}
