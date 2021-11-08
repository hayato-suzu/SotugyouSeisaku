using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityChan;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    //���ԕ\���e�L�X�g
    public Text timeText;

    //��������
    public float limit = 30.0f;

    //�Q�[���I�[�o�[�\���p�e�L�X�g
    public GameObject text;

    //UnityChan�i�[
    public GameObject player;

    //RestartManager�^
    private RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        //�C���X�^���X����
        restart = new RestartManager(player,text);

        //���Ԃ�ݒ�
        timeText.text = "�c�莞��" + limit + "�b";
    }

    // Update is called once per frame
    void Update()
    {
        //�Q�[���I�[�o�[��Ԃŉ�ʃN���b�N
        if(restart.IsGameOver() && Input.GetMouseButton(0))
        {
            Restart();
        }

        if(limit < 0)
        {
            //�Q�[���I�[�o�[��\��
            text.GetComponent<Text>().text = "TimeUp\n��ʃN���b�N�Ń��X�^�[�g";
            text.SetActive(true);

            //UnityChan�X�g�b�v
            player.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
            //AnimationOff
            player.GetComponent<Animator>().enabled = false;

            //RestartManager�ŏ�������
            restart.PrintGameOver();

            //���\�b�h�I��
            return;
        }

        //���Ԃ��J�E���g�_�E��
        limit -= Time.deltaTime;
        timeText.text = "�c�莞��" + limit.ToString("f1") + "�b";
    }

    //�V�[�����ēǂݍ���
    private void Restart()
    {
        //���݂�Scene�����擾����
        Scene loadScene = SceneManager.GetActiveScene();

        //Scene�̓Ǎ�
        SceneManager.LoadScene(loadScene.name);
    }
}
