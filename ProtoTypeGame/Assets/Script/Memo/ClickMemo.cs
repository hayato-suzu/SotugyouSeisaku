using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickMemo : MonoBehaviour
{
    public Text message;

    private void OnMouseDown()
    {
        //textを表示する
        message.text = "このオブジェクトに触れると\n特定の位置にワープできるよ！";

        StartCoroutine("TextSet");
    }

    IEnumerator TextSet()
    {
        //n秒後に消す
        yield return new WaitForSeconds(5.0f);

        message.text = "";
    }
}
