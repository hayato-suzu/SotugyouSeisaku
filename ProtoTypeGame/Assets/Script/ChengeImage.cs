using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChengeImage : MonoBehaviour
{
    public Sprite start;
    public Sprite next;
    private bool flg = true;

    public void ChangeImage()
    {
        var img = GetComponent<Image>();
        img.sprite = (flg) ? start : next;
        flg = !flg;
    }
}
