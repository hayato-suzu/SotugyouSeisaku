using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickButtomMemo : MonoBehaviour
{
    public Text message;
    private void OnMouseDown()
    {
        //text��\������
        message.text = "�{�^����������\n�d�|�����쓮�����I";

        StartCoroutine("TextSet");
    }

    IEnumerator TextSet()
    {
        //n�b��ɏ���
        yield return new WaitForSeconds(5.0f);

        message.text = "";
    }
}
