using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHitController : MonoBehaviour
{
    //Unityちゃん格納
    public GameObject player;

    //テキスト格納
    public GameObject text;

    //RestartManager型
    private RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        //インスタンス作成
        restart = new RestartManager(player, text);
    }

    // Update is called once per frame
    void Update()
    {
        //ボタンクリックでリスタート処理をする
        if (restart.IsGameOver() && Input.GetMouseButton(0))
        {
            restart.Restart();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //接触オブジェクトがUnityちゃんのとき
        if(other.gameObject.name == player.name)
        {
                //敵を止める
                GetComponent<NavMeshAgent>().isStopped = true;
                restart.PrintGameOver();
        }
    }
}
