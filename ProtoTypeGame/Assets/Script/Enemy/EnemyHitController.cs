using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHitController : MonoBehaviour
{
    //Unity�����i�[
    public GameObject player;

    //�e�L�X�g�i�[
    public GameObject text;

    //RestartManager�^
    private RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        //�C���X�^���X�쐬
        restart = new RestartManager(player, text);
    }

    // Update is called once per frame
    void Update()
    {
        //�{�^���N���b�N�Ń��X�^�[�g����������
        if (restart.IsGameOver() && Input.GetMouseButton(0))
        {
            restart.Restart();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //�ڐG�I�u�W�F�N�g��Unity�����̂Ƃ�
        if(other.gameObject.name == player.name)
        {
                //�G���~�߂�
                GetComponent<NavMeshAgent>().isStopped = true;
                restart.PrintGameOver();
        }
    }
}
