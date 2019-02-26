using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketScript : MonoBehaviour {

    //Startメソッドをコルーチンとして呼び出す
    IEnumerator Start(){
        // コンポーネントを取得
         = GetComponent<RocketScript>();

        while (true){
            // 弾をプレイヤーと同じ位置/角度で作成
            .光の球Prefab(transform);

            // shotDelay秒待つ
            yield return new WaitForSeconds(p.shotDelay);
        }
    }

    //毎フレーム呼ばれる関数
    void Update(){
        float x = Input.GetAxisRaw("Horizontal");//右・左
        float y = Input.GetAxisRaw("Vertical");//上・下
        //移動する向きを決める
        Vector2 direction = new Vector2(x, y).normalized;
        //移動する向きとスピードを代入する
        spaceship.Move(direction);
    }
}
