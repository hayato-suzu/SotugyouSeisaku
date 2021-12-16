using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DropManager : MonoBehaviour
{
    //格納する変数
    public GameObject player;
    public GameObject image;

    //-に設定する
    public float Drop = -13;

    //RestartManager型
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
        if (player.transform.position.y < Drop)
        {
            restart.PrintGameOver();
        }
    }

    public void ButtonRestart()
    {
        Restart();
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
