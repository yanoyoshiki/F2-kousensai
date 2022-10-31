using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carScript4 : MonoBehaviour
{
    public List<AxleInfo> axleInfos; // 個々の車軸の情報
    public float maxMotorTorque; //ホイールに適用可能な最大トルク
    public float maxSteeringAngle; // 適用可能な最大ハンドル角度

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

    public Vector3 com; //重心の位置
    public Rigidbody rb;


    private IEnumerator Inoperable(float i) // 操作を不能にする（引数の秒数間）
    {
        Debug.Log("X");
        carScript4 inputScript = this;
        inputScript.enabled = false; // スクリプトを無効化
        yield return new WaitForSeconds(i); // 引数の秒数だけ待つ
        inputScript.enabled = true; // スクリプトを有効化
        yield break;
    }


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = com; //重心の位置
        StartCoroutine("Inoperable", 5f); // ５秒処理停止
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
        //wheelcolliderの回転速度に合わせてタイヤモデルを回転させる
        wheelFLTrans.Rotate(wheelFL.rpm / 60 * 360 * Time.deltaTime, 0, 0);
        wheelFRTrans.Rotate(wheelFR.rpm / 60 * 360 * Time.deltaTime, 0, 0);
        wheelBLTrans.Rotate(wheelBL.rpm / 60 * 360 * Time.deltaTime, 0, 0);
        wheelBRTrans.Rotate(wheelBR.rpm / 60 * 360 * Time.deltaTime, 0, 0);

        //wheelcolliderの角度に合わせてタイヤモデルを回転する（フロントのみ）
        wheelFLTrans.localEulerAngles = new Vector3(wheelFLTrans.localEulerAngles.x, wheelFL.steerAngle - wheelFLTrans.localEulerAngles.z, wheelFLTrans.localEulerAngles.z);
        wheelFRTrans.localEulerAngles = new Vector3(wheelFRTrans.localEulerAngles.x, wheelFR.steerAngle - wheelFRTrans.localEulerAngles.z, wheelFRTrans.localEulerAngles.z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //復帰処理、必要なら
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
