using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrDisappearfloor : MonoBehaviour
{

    [Tooltip("�����n�߂�b��")] public float DisaStart_time;

    [Tooltip("�I�u�W�F�N�g�i�[�ϐ�")] public GameObject OrDisaObj;


    //
    [Tooltip("�J��Ԃ��b��")] public float Repeat_Time = 5.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("up", DisaStart_time,Repeat_Time);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void up()
    {
        if (OrDisaObj.activeSelf == true)
        {
            OrDisaObj.gameObject.SetActive(false);
        }
        else if(OrDisaObj.activeSelf == false) 
        {
            OrDisaObj.gameObject.SetActive(true);
        }
        
        
    }


    
    
}
