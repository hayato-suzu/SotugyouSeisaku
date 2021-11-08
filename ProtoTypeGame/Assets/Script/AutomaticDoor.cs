using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticDoor : MonoBehaviour
{
    //�h�A�̃A�j���[�^�[
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        //Animator�擾
        animator = transform.parent.GetComponent<Animator>();
    }

    //���m�G���A�ɓ������Ƃ�
    private void OnTriggerEnter(Collider other)
    {
        //�A�j���[�V�����p�����[�^�[��true
        animator.SetBool("Open", true);
    }

    //���m�G���A�ɏo���Ƃ�
    private void OnTriggerExit(Collider other)
    {
        //�A�j���[�V�����p�����[�^�[��false
        animator.SetBool("Open", false);
    }
}
