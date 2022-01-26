using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisonEnterSe : MonoBehaviour
{
    //����������ϐ�
    [SerializeField] AudioClip se1;

    //���f�[�^�̍Đ����u
    private AudioSource Audio;

    // Start is called before the first frame update
    void Start()
    {
        Audio = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Audio.PlayOneShot(se1);
        }
    }
}
