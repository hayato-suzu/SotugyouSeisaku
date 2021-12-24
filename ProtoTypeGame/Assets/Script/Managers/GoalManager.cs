using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityChan;

public class GoalManager : MonoBehaviour
{
    //Player格納変数
    public GameObject player;
    //TEXT格納変数  
    public GameObject text;

    public GameObject Image;

    public GameObject limit;

    public GameObject Enemy;
    //Goalしたかどうか判定する
    private bool isGoal = false;

    //RestartManager型
    private RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //当たり判定関数
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == player.name)
        {
            //Debug.Log("ユニティーちゃんと接触しました");

            //UnityChanストップ
            player.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
            //AnimationOff
            player.GetComponent<Animator>().enabled = false;

            //text内容をGOALに変更する
            //text.GetComponent<Text>().text = "GOAL\n画面クリックでリスタート";
            //text.SetActive(true);
            Image.SetActive(true);

            //Goal判定をtrueにする
            isGoal = true;
        }
    }

    private void Restart()
    {
        //現在のシーンを取得
        Scene LoadScene = SceneManager.GetActiveScene();

        //Sceneの読み直し
        SceneManager.LoadScene(LoadScene.name);
    }
}
