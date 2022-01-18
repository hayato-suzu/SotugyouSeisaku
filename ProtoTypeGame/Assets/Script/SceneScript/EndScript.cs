using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    private GameObject player;
    private GameObject image;
    private RestartManager restart;

    void Start()
    {
        //�C���X�^���X����
        restart = new RestartManager(player, image);
    }

    //�I���{�^�������������ʂ����
    public void ButtonEnd()
    {
        Application.Quit();
    }

    public void ButtonRestart()
    {
        Restart();
    }

    public void ButtonStart()
    {
        SceneManager.LoadScene("SelectScene");
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
