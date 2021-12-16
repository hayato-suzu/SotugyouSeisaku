using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DropManager : MonoBehaviour
{
    //�i�[����ϐ�
    public GameObject player;
    public GameObject image;

    //-�ɐݒ肷��
    public float Drop = -13;

    //RestartManager�^
    private RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        //�C���X�^���X����
        restart = new RestartManager(player, image);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < Drop)
        {
            restart.PrintGameOver();
        }
    }

    public void ButtonRestart()
    {
        Restart();
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
