using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmScript : MonoBehaviour
{

    [SerializeField] AudioClip bgm = null;
    [SerializeField] GameObject Restartimage;
    [SerializeField] GameObject Goalimage;
    AudioSource Audio;



    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
        Audio.clip = bgm;
        Audio.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Restartimage.activeSelf==true || Goalimage.activeSelf == true)
        {
            Audio.Stop();
        }
    }



}
