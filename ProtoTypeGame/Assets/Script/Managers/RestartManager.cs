using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityChan;


public class RestartManager : MonoBehaviour
{
    //�i�[����ϐ�
    private GameObject player;
    private GameObject image;

    private bool isGameOver = false;

    //�R���X�g���N�^
    public RestartManager(GameObject player,GameObject image)
    {
        //player,text�����炩���ߎ󂯎��
        this.player = player;
        this.image = image;
    }

    public void PrintGameOver()
    {
        //GameOver�\��
        image.SetActive(true);

        //UnityChan�X�g�b�v
        player.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
        //AnimationOff
        player.GetComponent<Animator>().enabled = false;

        //�Q�[���I�[�o�[
        isGameOver = true;
    }

    //�V�[�����ēǂݍ���
    public void Restart()
    {
        //���݂�Scene�����擾����
        Scene loadScene = SceneManager.GetActiveScene();

        //Scene�̓Ǎ�
        SceneManager.LoadScene(loadScene.name);
    }

    //�Q�[���I�[�o�[���ǂ����̊m�F
    public bool IsGameOver()
    {
        return isGameOver;
    }
}
