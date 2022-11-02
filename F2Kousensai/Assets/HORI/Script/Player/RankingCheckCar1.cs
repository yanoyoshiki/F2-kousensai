using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankingCheckCar1 : MonoBehaviour
{

    //取得するもの
    //車各種（何台出るかわからんので、宣言だけしておいてUpdate中で取得がいいかも）
    //各チェックポイント
    //各プレイヤーの順位UIに干渉できるスクリプト（何台出るかわからんので、宣言だけしておいてUpdate中で取得がいいかも）

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //通過した車のタグを各チェックポイントのスクリプトから判別
        //チェックポイントの数だけpublic voidの関数を用意して、各チェックポイントに付けたスクリプトから呼び出させる
        //呼び出した関数からどの車がどこを通過したかを記録
        //記録から順位を判別、表記は1/nではなく１位、２位にする
        //もし同じ区間内に車が存在する場合、現在の区間の単位方向ベクトルと、直前に通過したチェックポイントからいまの座標までのベクトルの内積が進行度となるので、進行度の大きい方が上の順位となる
    }
}
