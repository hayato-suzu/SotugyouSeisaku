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
        message.text = "�����p�X���[�h\n0123";

        StartCoroutine("TextSet");
    }

    IEnumerator TextSet()
    {
        //n�b��ɏ���
        yield return new WaitForSeconds(5.0f);

        message.text = "";
    }
}
