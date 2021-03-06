using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityChan;


public class RestartManager : MonoBehaviour
{
    //格納する変数
    private GameObject player;
    private GameObject image;

    private bool isGameOver = false;

    //コンストラクタ
    public RestartManager(GameObject player,GameObject image)
    {
        //player,textをあらかじめ受け取る
        this.player = player;
        this.image = image;
    }

    public void PrintGameOver()
    {
        //GameOver表示
        image.SetActive(true);

        //UnityChanストップ
        player.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
        //AnimationOff
        player.GetComponent<Animator>().enabled = false;

        //ゲームオーバー
        isGameOver = true;
    }

    //シーンを再読み込み
    public void Restart()
    {
        //現在のScene名を取得する
        Scene loadScene = SceneManager.GetActiveScene();

        //Sceneの読込
        SceneManager.LoadScene(loadScene.name);
    }

    //ゲームオーバーかどうかの確認
    public bool IsGameOver()
    {
        return isGameOver;
    }
}
