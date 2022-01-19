using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    private GameObject player;
    private GameObject image;
    private RestartManager restart;

    void Start()
    {
        //インスタンス生成
        restart = new RestartManager(player, image);
    }

    //終了ボタンを押したら画面を閉じる
    public void ButtonEnd()
    {
        Application.Quit();
    }

    public void ButtonRestart()
    {
        Restart();
    }

    public void ButtonStart()
    {
        SceneManager.LoadScene("SelectScene");
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
