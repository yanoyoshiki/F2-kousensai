using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutputCarSpeed2 : MonoBehaviour
{

    //public GameObject SpeedObject;
    public carScript2 car;

    [SerializeField]
    private Image speedImage = null;
    [SerializeField]
    private Text speedText = null;
    [SerializeField]
    private float percentage = 10f;

    float MaxSpeed = 85; //Rigidbody��Drag��0.25�Ŗ�80�ADrag���グ���MaxSpeed�͌���

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Text spped_text = SpeedObject.GetComponent<Text>();
        float car_velocity = car.SpeedCheck();

        //�@Image�̕\�������ő呬�x�ɑ΂��錻�݂̑��x�Ōv�Z����
        var ratio = Mathf.InverseLerp(0f, 1f, Mathf.Abs(car_velocity) / MaxSpeed);
        //�@���x�p��Image�̍ŏ��ƍő��␳�����l�Ōv�Z
        speedImage.fillAmount = Mathf.Lerp(percentage / MaxSpeed, (MaxSpeed - percentage) / MaxSpeed, ratio);
        //�@���݂̑��x���e�L�X�g�ɕ\������
        speedText.text = Mathf.Abs(car_velocity).ToString("000") + "km/h";
    }
}
