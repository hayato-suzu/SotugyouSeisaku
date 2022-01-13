using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityChan;
using UnityEngine.Video;

public class GoalManager : MonoBehaviour
{
    //Player�i�[�ϐ�
    public GameObject player;
    //TEXT�i�[�ϐ�  
    public GameObject text;
    public GameObject Time;

    public GameObject Image;

    public GameObject VideoPlane;
    private float VideoPlay = 0;

    public GameObject limit;

    public GameObject Enemy;
    //Goal�������ǂ������肷��
    private bool isGoal = false;

    VideoPlayer video;

    //RestartManager�^
    private RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        VideoPlay = 0;
        video = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(VideoPlay==1)
        {
            if (video.isPlaying)
            {
                video.Pause();
            }
            else
            {
                video.Play();
                VideoPlay = 0;
            }
        }
        
    }

    //�����蔻��֐�
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == player.name)
        {
            //Debug.Log("���j�e�B�[�����ƐڐG���܂���");

            //UnityChan�X�g�b�v
            player.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
            //AnimationOff
            player.GetComponent<Animator>().enabled = false;

            Image.SetActive(true);
            VideoPlane.SetActive(true);
            VideoPlay++;

            Destroy(Time.gameObject);

            //Goal�����true�ɂ���
            isGoal = true;
        }
    }

    private void Restart()
    {
        //���݂̃V�[�����擾
        Scene LoadScene = SceneManager.GetActiveScene();

        //Scene�̓ǂݒ���
        SceneManager.LoadScene(LoadScene.name);
    }
}
