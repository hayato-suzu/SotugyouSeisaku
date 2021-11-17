using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpBlock : MonoBehaviour
{
    private Rigidbody rigid;
    private Vector3 defaultPos;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        defaultPos = transform.position;
    }

    // Update is called once per frame
    //フレーム毎に呼ばれる関数、固定フレーム
    void FixedUpdate()
    {
        //時間経過で0～2までの値を繰り返す
        //上に動く
        rigid.MovePosition(new Vector3(defaultPos.x, defaultPos.y + Mathf.PingPong(Time.time, 4), defaultPos.z));
    }
}
