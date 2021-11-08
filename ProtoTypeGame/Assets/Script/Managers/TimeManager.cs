using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityChan;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    //時間表示テキスト
    public Text timeText;

    //制限時間
    public float limit = 30.0f;

    //ゲームオーバー表示用テキスト
    public GameObject text;

    //UnityChan格納
    public GameObject player;

    //RestartManager型
    private RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        //インスタンス生成
        restart = new RestartManager(player,text);

        //時間を設定
        timeText.text = "残り時間" + limit + "秒";
    }

    // Update is called once per frame
    void Update()
    {
        //ゲームオーバー状態で画面クリック
        if(restart.IsGameOver() && Input.GetMouseButton(0))
        {
            Restart();
        }

        if(limit < 0)
        {
            //ゲームオーバーを表示
            text.GetComponent<Text>().text = "TimeUp\n画面クリックでリスタート";
            text.SetActive(true);

            //UnityChanストップ
            player.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
            //AnimationOff
            player.GetComponent<Animator>().enabled = false;

            //RestartManagerで処理する
            restart.PrintGameOver();

            //メソッド終了
            return;
        }

        //時間をカウントダウン
        limit -= Time.deltaTime;
        timeText.text = "残り時間" + limit.ToString("f1") + "秒";
    }

    //シーンを再読み込み
    private void Restart()
    {
        //現在のScene名を取得する
        Scene loadScene = SceneManager.GetActiveScene();

        //Sceneの読込
        SceneManager.LoadScene(loadScene.name);
    }
}
