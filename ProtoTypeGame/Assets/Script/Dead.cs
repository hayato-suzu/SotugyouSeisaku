using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityChan;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    public GameObject player;

    public GameObject image;

    private RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        //インスタンス生成
        restart = new RestartManager(player, image);
    }

    public void ButtonRestart()
    {
        Restart();
    }

    //UnityChanの当たり判定
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == player.name)
        {
            //ゲームオーバー
            restart.PrintGameOver();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == player.name)
        {
            //ゲームオーバー
            restart.PrintGameOver();
        }
    }

    //シーンを再読み込み
    private void Restart()
    {
        //現在のScene名を取得
        Scene loadScene = SceneManager.GetActiveScene();

        //Sceneリセット
        SceneManager.LoadScene(loadScene.name);
    }
}
