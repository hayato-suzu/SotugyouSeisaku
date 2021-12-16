using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityChan;

public class DeadWallController : MonoBehaviour
{
    //�I�u�W�F�N�g�̃X�s�[�h
    public float speed = 0.005f;

    //�I�u�W�F�N�g�̉��ړ��ő�l
    public float max_x = 10.0f;

    //���j�e�B�����i�[�ϐ�
    public GameObject player;
    //�e�L�X�g�i�[�ϐ�
    public GameObject image;

    //�Q�[���I�[�o�[����
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
        //�t���[����speed�̒l������x�������Ɉړ�����
        this.gameObject.transform.Translate(speed, 0, 0);

        //Transform��x�l�����l�𒴂����Ƃ��Ɍ����𔽑΂ɂ���
        if (this.gameObject.transform.position.x > max_x || this.gameObject.transform.position.x < (-max_x))
        {
            speed *= -1;
        }
    }

    public void ButtonRestart()
    {
        Restart();
    }

    //UnityChan�̓����蔻��
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == player.name)
        {
            //�����Ȃ�����
            player.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
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

