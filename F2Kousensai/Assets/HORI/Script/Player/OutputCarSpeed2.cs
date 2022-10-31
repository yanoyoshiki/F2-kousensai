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

    float MaxSpeed = 85; //RigidbodyのDragが0.25で約80、Dragを上げるとMaxSpeedは減少

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Text spped_text = SpeedObject.GetComponent<Text>();
        float car_velocity = car.SpeedCheck();

        //　Imageの表示率を最大速度に対する現在の速度で計算する
        var ratio = Mathf.InverseLerp(0f, 1f, Mathf.Abs(car_velocity) / MaxSpeed);
        //　速度用のImageの最小と最大を補正した値で計算
        speedImage.fillAmount = Mathf.Lerp(percentage / MaxSpeed, (MaxSpeed - percentage) / MaxSpeed, ratio);
        //　現在の速度をテキストに表示する
        speedText.text = Mathf.Abs(car_velocity).ToString("000") + "km/h";
    }
}
