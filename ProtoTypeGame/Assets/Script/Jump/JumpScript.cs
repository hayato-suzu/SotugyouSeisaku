using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Animator anim = GetComponent<Animator>();

        //spaceが入力されたらジャンプする
        if(Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("Jump", true);
        }

        //GetCurrentAnimatorStateInfo(0)でanimatorの現在状況をstateに格納する
        AnimatorStateInfo state = anim.GetCurrentAnimatorStateInfo(0);

        //ジャンプ中ならfalseを入れる
        if(state.IsName("Locomotion.Jump"))
        {
            anim.SetBool("Jump", false);
        }
    }
}
