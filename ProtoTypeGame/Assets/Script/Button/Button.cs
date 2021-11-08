using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    //開けるアニメーション
    [SerializeField] Animation anim = default;

    public void Open()
    {
        anim.Play("ButtonOpenDoor");
    }
}
