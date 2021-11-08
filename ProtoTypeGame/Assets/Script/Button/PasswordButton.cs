using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordButton : MonoBehaviour
{
    //�����ƈ�v���Ă��邩�m�F
    //�������ɊJ����󔠐ݒ�
    [SerializeField] Button button = default;

    //���𐔎�
    int[] correctAnswer = { 1 };

    //���[�U�[����
    [SerializeField] DialButton[] dialButtons = default;

    public void OnClickButton()
    {
        if(CheckClear())
        {
            //button
            //Debug.Log("push");
            button.Open();
        }
    }

    //�����ƃ��[�U�[���͂��m���߂�
    bool CheckClear()
    {
        //�_�C�A���i���o�[����������܂�
        for (int i = 0; i < dialButtons.Length; i++)
        {
            if (dialButtons[i].number != correctAnswer[i])
            {
                //��v���Ȃ��ꍇ
                return false;
            }
        }
        return true;
    }
}
