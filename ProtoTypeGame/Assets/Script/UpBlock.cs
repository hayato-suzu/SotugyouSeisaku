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
    //�t���[�����ɌĂ΂��֐��A�Œ�t���[��
    void FixedUpdate()
    {
        //���Ԍo�߂�0�`2�܂ł̒l���J��Ԃ�
        //��ɓ���
        rigid.MovePosition(new Vector3(defaultPos.x, defaultPos.y + Mathf.PingPong(Time.time, 4), defaultPos.z));
    }
}
