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
        message.text = "初期パスワード\n0123";

        StartCoroutine("TextSet");
    }

    IEnumerator TextSet()
    {
        //n秒後に消す
        yield return new WaitForSeconds(5.0f);

        message.text = "";
    }
}
