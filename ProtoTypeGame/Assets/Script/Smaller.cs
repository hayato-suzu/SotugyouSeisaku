using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smaller : MonoBehaviour
{
    [Tooltip("�������Ə��������邩�̐��l")] public float Scale_rate;
    [Tooltip("�ŏI����")] public float Scale_min;



    Vector3 Scale_sub;
    


    // Start is called before the first frame update
    void Start()
    {
        //�p�[�Z���g�ɕϊ�
        Scale_min = Scale_min / 100;
        Scale_rate = Scale_rate / 100;
        //����Vector3�ɕϊ�
        Scale_sub= new Vector3(this.transform.localScale.x * Scale_rate,0, this.transform.localScale.z*Scale_rate);
        //x�̍ŏ��l�ɕϊ�
        Scale_min = this.transform.localScale.x * Scale_min;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            //��ɏ���Ă��邩 and�@x�̍ŏ��l<���������x�̐��l
            if (collision.transform.position.y > this.transform.position.y && Scale_min < this.transform.localScale.x - Scale_sub.x)
            {
                
                this.transform.localScale = this.transform.localScale - Scale_sub;
            }
        }
        
        
    }

}
