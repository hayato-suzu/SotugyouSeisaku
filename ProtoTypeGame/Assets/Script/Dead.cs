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
        //インスタンス生成
        restart = new RestartManager(player, text);
    }

    private void Update()
    {
        //ゲームオーバー状態で画面クリック
        if (restart.IsGameOver() && Input.GetMouseButton(0))
        {
            Restart();
        }
    }

    //UnityChanの当たり判定
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == player.name)
        {
            //動けなくする
            player.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
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
