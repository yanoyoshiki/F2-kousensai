using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : ItemChange {

    // Use this for initialization
    void Start () {
        // mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update () {
        
    }

    // public void Mr (){
    //     // mr = GetComponent<MeshRenderer>();
    //     mr.material.color = mr.material.color - new Color32(0,0,0,255);
    // }

    // IEnumerator Defeat() {
    //     //終わるまで待ってほしい処理を書く
    //     //例：敵が倒れるアニメーションを開始
    //     gameObject.SetActive(false);
    //     //2秒待つ
    //     yield return new WaitForSeconds(4);

    //     //再開してから実行したい処理を書く
    //     //例：敵オブジェクトを破壊
    //     gameObject.SetActive(true);
    // }

    //今回追加
    // void OnTriggerEnter(Collider hit)
    // {
    //   //今回追加
    //     if (hit.CompareTag("Player1"))
    //     {
    //         //処理を記述
    //         //今回追加
    //         IEnumerator defeat = Defeat();
    //         // gameObject.SetActive (false);
    //         StartCoroutine(defeat);
    //         // gameObject.SetActive (true);
    //     }
    // }
}