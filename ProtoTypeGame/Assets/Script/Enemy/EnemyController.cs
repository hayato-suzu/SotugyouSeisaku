using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    //�ړI�n�ƂȂ�I�u�W�F�N�g�̃g�����X�t�H�[���i�[
    public Transform target;

    //�G�[�W�F���g�ƂȂ�I�u�W�F�N�gNavMeshAgent�i�[
    public NavMeshAgent agent;

    private void Update()
    {
        //�ړI�n�̍��W��ݒ肷��
        agent.destination = target.position;
    }
}
