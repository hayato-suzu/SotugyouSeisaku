using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{

    //�J����A�j���[�V����
    [SerializeField] Animation anim = default;

    public void Open()
    {
        anim.Play("OpenChest");
    }
}
