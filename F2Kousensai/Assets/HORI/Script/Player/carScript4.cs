using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carScript4 : MonoBehaviour
{
    public List<AxleInfo> axleInfos; // �X�̎Ԏ��̏��
    public float maxMotorTorque; //�z�C�[���ɓK�p�\�ȍő�g���N
    public float maxSteeringAngle; // �K�p�\�ȍő�n���h���p�x

    public WheelCollider wheelFL;
    public WheelCollider wheelFR;
    public WheelCollider wheelBL;
    public WheelCollider wheelBR;

    public Transform wheelFLTrans;
    public Transform wheelFRTrans;
    public Transform wheelBLTrans;
    public Transform wheelBRTrans;
    float steering = 0.0f;
    float motor = 0.0f;

    public Vector3 com; //�d�S�̈ʒu
    public Rigidbody rb;


    private IEnumerator Inoperable(float i) // �����s�\�ɂ���i�����̕b���ԁj
    {
        Debug.Log("X");
        carScript4 inputScript = this;
        inputScript.enabled = false; // �X�N���v�g�𖳌���
        yield return new WaitForSeconds(i); // �����̕b�������҂�
        inputScript.enabled = true; // �X�N���v�g��L����
        yield break;
    }


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = com; //�d�S�̈ʒu
        StartCoroutine("Inoperable", 5f); // �T�b������~
    }

    public float SpeedCheck()
    {
        rb = GetComponent<Rigidbody>();
        float velocity = rb.velocity.magnitude;
        float speed = velocity * 3600 / 1000;
        return speed;
    }

    // Update is called once per frame
    void Update()
    {
        //wheelcollider�̉�]���x�ɍ��킹�ă^�C�����f������]������
        wheelFLTrans.Rotate(wheelFL.rpm / 60 * 360 * Time.deltaTime, 0, 0);
        wheelFRTrans.Rotate(wheelFR.rpm / 60 * 360 * Time.deltaTime, 0, 0);
        wheelBLTrans.Rotate(wheelBL.rpm / 60 * 360 * Time.deltaTime, 0, 0);
        wheelBRTrans.Rotate(wheelBR.rpm / 60 * 360 * Time.deltaTime, 0, 0);

        //wheelcollider�̊p�x�ɍ��킹�ă^�C�����f������]����i�t�����g�̂݁j
        wheelFLTrans.localEulerAngles = new Vector3(wheelFLTrans.localEulerAngles.x, wheelFL.steerAngle - wheelFLTrans.localEulerAngles.z, wheelFLTrans.localEulerAngles.z);
        wheelFRTrans.localEulerAngles = new Vector3(wheelFRTrans.localEulerAngles.x, wheelFR.steerAngle - wheelFRTrans.localEulerAngles.z, wheelFRTrans.localEulerAngles.z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //���A�����A�K�v�Ȃ�
        }
    }

    public void FixedUpdate()
    {
        motor = maxMotorTorque * Input.GetAxis("Vertical");
        steering = maxSteeringAngle * Input.GetAxis("Horizontal");

        foreach (AxleInfo axleInfo in axleInfos)
        {
            if (axleInfo.steering)
            {
                axleInfo.leftWheel.steerAngle = steering;
                axleInfo.rightWheel.steerAngle = steering;
            }
            if (axleInfo.motor)
            {
                axleInfo.leftWheel.motorTorque = motor;
                axleInfo.rightWheel.motorTorque = motor;
            }
        }
    }

}
