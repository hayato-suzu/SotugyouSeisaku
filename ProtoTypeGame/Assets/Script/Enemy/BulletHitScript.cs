using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityChan;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//�e�ɔ�e�����Ƃ��̏���

public class BulletHitScript : MonoBehaviour
{
    private GameObject player;

    public GameObject text;

    private RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        //�C���X�^���X����
        restart = new RestartManager(player, text);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //�����Ȃ�����
            GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
            //AnimationOff
            player.GetComponent<Animator>().enabled = false;

            //�Q�[���I�[�o�[
            restart.PrintGameOver();
        }
    }

    //�V�[�����ēǂݍ���
    private void Restart()
    {
        //���݂�Scene�����擾
        Scene loadScene = SceneManager.GetActiveScene();

        //Scene���Z�b�g
        SceneManager.LoadScene(loadScene.name);
    }
}
