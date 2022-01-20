using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBlock : MonoBehaviour
{
    public GameObject invisiblefloor;

    public float time = 5;

    public AudioClip se;

    private void Start()
    {
        //スタート時消しとく
        invisiblefloor.SetActive(false);
    }

    private void OnMouseDown()
    {
        AudioSource.PlayClipAtPoint(se, transform.position);
        //あるオブジェクトをマウスで押したとき表示
        invisiblefloor.SetActive(true);

        //publicで設定した時間後に処理(SowOut)を呼び出す
        Invoke("ShowOut", time);
    }

    private void ShowOut()
    {
        //非表示にする
        invisiblefloor.SetActive(false);
    }
}
