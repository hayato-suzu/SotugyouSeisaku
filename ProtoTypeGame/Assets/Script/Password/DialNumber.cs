using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialNumber : MonoBehaviour
{
    //表示するためのもの
    [SerializeField] TMP_Text numberText = default;

    //数字
    public int number = 0;

    //クリックされると数字を増やす
    public void Onclick()
    {
        number++;

        //9までいったら0にする
        if(number > 9)
        {
            number = 0;
        }
        //textに反映させて表示する
        numberText.text = number.ToString();
    }
}
