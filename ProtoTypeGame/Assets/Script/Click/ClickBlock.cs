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
        //�X�^�[�g�������Ƃ�
        invisiblefloor.SetActive(false);
    }

    private void OnMouseDown()
    {
        AudioSource.PlayClipAtPoint(se, transform.position);
        //����I�u�W�F�N�g���}�E�X�ŉ������Ƃ��\��
        invisiblefloor.SetActive(true);

        //public�Őݒ肵�����Ԍ�ɏ���(SowOut)���Ăяo��
        Invoke("ShowOut", time);
    }

    private void ShowOut()
    {
        //��\���ɂ���
        invisiblefloor.SetActive(false);
    }
}
