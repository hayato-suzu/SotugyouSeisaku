using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticDoor : MonoBehaviour
{
    //ドアのアニメーター
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        //Animator取得
        animator = transform.parent.GetComponent<Animator>();
    }

    //検知エリアに入ったとき
    private void OnTriggerEnter(Collider other)
    {
        //アニメーションパラメーターをtrue
        animator.SetBool("Open", true);
    }

    //検知エリアに出たとき
    private void OnTriggerExit(Collider other)
    {
        //アニメーションパラメーターをfalse
        animator.SetBool("Open", false);
    }
}
