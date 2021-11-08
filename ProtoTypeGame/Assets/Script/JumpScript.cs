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

        //space�����͂��ꂽ��W�����v����
        if(Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("Jump", true);
        }

        //GetCurrentAnimatorStateInfo(0)��animator�̌��ݏ󋵂�state�Ɋi�[����
        AnimatorStateInfo state = anim.GetCurrentAnimatorStateInfo(0);

        //�W�����v���Ȃ�false������
        if(state.IsName("Locomotion.Jump"))
        {
            anim.SetBool("Jump", false);
        }
    }
}
