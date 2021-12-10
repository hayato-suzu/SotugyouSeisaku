using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadGround : MonoBehaviour
{
    //�I�u�W�F�N�g�̃X�s�[�h
    public float speed = 0.005f;

    //�I�u�W�F�N�g�̉��ړ��ő�l
    public float max_y = 1.0f;

    //���j�e�B�����i�[�ϐ�
    public GameObject player;
    //�e�L�X�g�i�[�ϐ�
    public GameObject text;

    //�Q�[���I�[�o�[����
    private RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        //�C���X�^���X����
        restart = new RestartManager(player, text);
    }

    // Update is called once per frame
    void Update()
    {
        //�t���[����speed�̒l������y�������Ɉړ�����
        this.gameObject.transform.Translate(0, speed, 0);

        //Transform��x�l�����l�𒴂����Ƃ��Ɍ����𔽑΂ɂ���
        if (this.gameObject.transform.position.y > max_y || this.gameObject.transform.position.y < (-max_y))
        {
            speed *= -1;
        }

        if (restart.IsGameOver() && Input.GetMouseButton(0))
        {
            Restart();
        }
    }

    //UnityChan�̓����蔻��
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == player.name)
        {

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
