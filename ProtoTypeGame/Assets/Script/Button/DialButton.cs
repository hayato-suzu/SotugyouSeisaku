using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialButton : MonoBehaviour
{
    //�\�����邽�߂̂���
    [SerializeField] TMP_Text numberText = default;

    //����
    public int number = 0;

    //�N���b�N�����Ɛ����𑝂₷
    public void Onclick()
    {
        number++;

        //1�܂ł�������0�ɂ���
        if (number > 1)
        {
            number = 0;
        }
        //text�ɔ��f�����ĕ\������
        //numberText.text = number.ToString();
    }
}
