using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordPanel : MonoBehaviour
{
    //�����ƈ�v���Ă��邩�m�F
    //�������ɊJ����󔠐ݒ�
    [SerializeField] Chest chest = default;

    //���𐔎�
    int[] correctAnswer = { 0, 1, 2, 3 };

    //���[�U�[����
    [SerializeField] DialNumber[] dialNumbers = default;

    public void OnClickButton()
    {
        if(CheckClear())
        {
            //��Open
            //Debug.Log("Open");
            chest.Open();
        }
    }

    //�����ƃ��[�U�[���͂��m���߂�
    bool CheckClear()
    {
        //�_�C�A���i���o�[����������܂�
        for(int i = 0; i < dialNumbers.Length; i++)
        {
            if(dialNumbers[i].number != correctAnswer[i])
            {
                //��v���Ȃ��ꍇ
                return false;
            }
        }
        return true;
    }
}
