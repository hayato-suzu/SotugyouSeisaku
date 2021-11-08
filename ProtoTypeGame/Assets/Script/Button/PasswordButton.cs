using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordButton : MonoBehaviour
{
    //正解と一致しているか確認
    //正解時に開ける宝箱設定
    [SerializeField] Button button = default;

    //正解数字
    int[] correctAnswer = { 1 };

    //ユーザー入力
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

    //正解とユーザー入力を確かめる
    bool CheckClear()
    {
        //ダイアルナンバーが正解するまで
        for (int i = 0; i < dialButtons.Length; i++)
        {
            if (dialButtons[i].number != correctAnswer[i])
            {
                //一致しない場合
                return false;
            }
        }
        return true;
    }
}
