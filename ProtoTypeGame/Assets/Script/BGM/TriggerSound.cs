using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    //�G�ꂽ�Ƃ��̉�
    public AudioClip se;

    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(se, transform.position);
    }
}
