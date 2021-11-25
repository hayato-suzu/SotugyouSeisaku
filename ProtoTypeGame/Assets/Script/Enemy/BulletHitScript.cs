using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityChan;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//弾に被弾したときの処理

public class BulletHitScript : MonoBehaviour
{
    private GameObject player;

    public GameObject text;

    private RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        //インスタンス生成
        restart = new RestartManager(player, text);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //動けなくする
            GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
            //AnimationOff
            player.GetComponent<Animator>().enabled = false;

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
