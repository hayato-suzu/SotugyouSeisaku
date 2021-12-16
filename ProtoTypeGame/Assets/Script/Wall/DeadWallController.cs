using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityChan;

public class DeadWallController : MonoBehaviour
{
    //オブジェクトのスピード
    public float speed = 0.005f;

    //オブジェクトの横移動最大値
    public float max_x = 10.0f;

    //ユニティちゃん格納変数
    public GameObject player;
    //テキスト格納変数
    public GameObject image;

    //ゲームオーバー判定
    private RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        //インスタンス生成
        restart = new RestartManager(player, image);
    }

    // Update is called once per frame
    void Update()
    {
        //フレーム毎speedの値分だけx軸方向に移動する
        this.gameObject.transform.Translate(speed, 0, 0);

        //Transformのx値が一定値を超えたときに向きを反対にする
        if (this.gameObject.transform.position.x > max_x || this.gameObject.transform.position.x < (-max_x))
        {
            speed *= -1;
        }
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

