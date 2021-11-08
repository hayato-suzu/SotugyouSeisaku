using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    //オブジェクトのスピード
    public float speed = 0.005f;

    //オブジェクトの横移動最大値
    public float max_x = 10.0f;

    // Update is called once per frame
    void Update()
    {
        //フレーム毎speedの値分だけx軸方向に移動する
        this.gameObject.transform.Translate(speed, 0, 0);

        //Transformのx値が一定値を超えたときに向きを反対にする
        if (this.gameObject.transform.position.x > max_x || this.gameObject.transform.position.x < (-max_x))
        {
            speed *= -1;
        }
    }
}
