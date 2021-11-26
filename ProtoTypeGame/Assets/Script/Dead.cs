using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityChan;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    public GameObject player;

    public GameObject text;

    private RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        //�C���X�^���X����
        restart = new RestartManager(player, text);
    }

    private void Update()
    {
        //�Q�[���I�[�o�[��Ԃŉ�ʃN���b�N
        if (restart.IsGameOver() && Input.GetMouseButton(0))
        {
            Restart();
        }
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
