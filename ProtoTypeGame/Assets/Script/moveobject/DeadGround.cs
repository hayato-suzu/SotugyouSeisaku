using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadGround : MonoBehaviour
{
    //オブジェクトのスピード
    public float speed = 0.005f;

    //オブジェクトの横移動最大値
    public float max_y = 1.0f;

    //ユニティちゃん格納変数
    public GameObject player;
    //テキスト格納変数
    public GameObject text;

    //ゲームオーバー判定
    private RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        //インスタンス生成
        restart = new RestartManager(player, text);
    }

    // Update is called once per frame
    void Update()
    {
        //フレーム毎speedの値分だけy軸方向に移動する
        this.gameObject.transform.Translate(0, speed, 0);

        //Transformのx値が一定値を超えたときに向きを反対にする
        if (this.gameObject.transform.position.y > max_y || this.gameObject.transform.position.y < (-max_y))
        {
            speed *= -1;
        }

        if (restart.IsGameOver() && Input.GetMouseButton(0))
        {
            Restart();
        }
    }

    //UnityChanの当たり判定
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
