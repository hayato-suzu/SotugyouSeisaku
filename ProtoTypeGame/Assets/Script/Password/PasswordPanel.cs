using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordPanel : MonoBehaviour
{
    //正解と一致しているか確認
    //正解時に開ける宝箱設定
    [SerializeField] Chest chest = default;

    //正解数字
    int[] correctAnswer = { 0, 1, 2, 3 };

    //ユーザー入力
    [SerializeField] DialNumber[] dialNumbers = default;

    public void OnClickButton()
    {
        if(CheckClear())
        {
            //宝箱Open
            //Debug.Log("Open");
            chest.Open();
        }
    }

    //正解とユーザー入力を確かめる
    bool CheckClear()
    {
        //ダイアルナンバーが正解するまで
        for(int i = 0; i < dialNumbers.Length; i++)
        {
            if(dialNumbers[i].number != correctAnswer[i])
            {
                //一致しない場合
                return false;
            }
        }
        return true;
    }
}
