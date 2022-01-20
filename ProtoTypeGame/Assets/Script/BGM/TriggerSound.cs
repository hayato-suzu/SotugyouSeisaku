using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    //触れたときの音
    public AudioClip se;

    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(se, transform.position);
    }
}
