using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityChan;

public class GoalManager : MonoBehaviour
{
    //Player�i�[�ϐ�
    public GameObject player;
    //TEXT�i�[�ϐ�  
    public GameObject text;

    public GameObject Image;

    public GameObject limit;

    public GameObject Enemy;
    //Goal�������ǂ������肷��
    private bool isGoal = false;

    //RestartManager�^
    private RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

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

            //text���e��GOAL�ɕύX����
            //text.GetComponent<Text>().text = "GOAL\n��ʃN���b�N�Ń��X�^�[�g";
            //text.SetActive(true);
            Image.SetActive(true);

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
