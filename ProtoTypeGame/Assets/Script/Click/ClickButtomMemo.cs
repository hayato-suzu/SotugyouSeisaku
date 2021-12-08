using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickButtomMemo : MonoBehaviour
{
    public Text message;
    private void OnMouseDown()
    {
        //textを表示する
        message.text = "ボタンを押すと\n仕掛けが作動するよ！";

        StartCoroutine("TextSet");
    }

    IEnumerator TextSet()
    {
        //n秒後に消す
        yield return new WaitForSeconds(5.0f);

        message.text = "";
    }
}
