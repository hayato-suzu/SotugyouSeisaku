using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickMemo : MonoBehaviour
{
    public Text message;

    private void OnMouseDown()
    {
        //text��\������
        message.text = "���̃I�u�W�F�N�g�ɐG����\n����̈ʒu�Ƀ��[�v�ł����I";

        StartCoroutine("TextSet");
    }

    IEnumerator TextSet()
    {
        //n�b��ɏ���
        yield return new WaitForSeconds(5.0f);

        message.text = "";
    }
}
