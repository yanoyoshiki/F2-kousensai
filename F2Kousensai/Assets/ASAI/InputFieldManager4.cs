using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class InputFieldManager4 : MonoBehaviour
{
    //�o�͗p�̃e�L�X�g
    public Text displayText;

    //inputField��OnEndEdit�ɐݒ肷��p�̊֐�
    public void OnEndEdit()
    {
        //InputField�R���|�[�l���g��text��ϐ��ɑ��
        string inputFieldText = GetComponent<InputField>().text;

        //�o�͗p�̃e�L�X�g�ɑ��
        displayText.text = inputFieldText;



    }
    public void name_insert()
    {
        string inputFieldText = GetComponent<InputField>().text;
        RESULT1.best_playerName_sum[8] = inputFieldText;



        {
            SceneManager.LoadScene("Best_time");
        }
    }
}