using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    //�I�u�W�F�N�g�̃X�s�[�h
    public float speed = 0.005f;

    //�I�u�W�F�N�g�̉��ړ��ő�l
    public float max_x = 10.0f;

    // Update is called once per frame
    void Update()
    {
        //�t���[����speed�̒l������x�������Ɉړ�����
        this.gameObject.transform.Translate(speed, 0, 0);

        //Transform��x�l�����l�𒴂����Ƃ��Ɍ����𔽑΂ɂ���
        if (this.gameObject.transform.position.x > max_x || this.gameObject.transform.position.x < (-max_x))
        {
            speed *= -1;
        }
    }
}
