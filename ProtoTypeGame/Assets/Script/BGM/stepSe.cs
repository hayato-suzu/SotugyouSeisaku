using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stepSe : MonoBehaviour
{
    public AudioClip step;
    AudioSource audioSource;
    public float wait = 0.05f;
    private bool flag = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
            flag = true;
            StartCoroutine("StepSe");
        }
    }

    IEnumerator StepSe()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(step);
            yield return new WaitForSeconds(wait);
        }
        
        if (Input.GetKeyUp("w"))
        {
            flag = false;
            StartCoroutine("StopSe");
        }
    }

    IEnumerator StopSe()
    {
        audioSource = this.GetComponent<AudioSource>();
        this.audioSource.Stop();
        yield break;
    }
}
