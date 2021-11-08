using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    //目的地となるオブジェクトのトランスフォーム格納
    public Transform target;

    //エージェントとなるオブジェクトNavMeshAgent格納
    public NavMeshAgent agent;

    private void Update()
    {
        //目的地の座標を設定する
        agent.destination = target.position;
    }
}
