using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityChan;
using UnityEngine.Video;

public class GoalManager : MonoBehaviour
{
    //Player格納変数
    public GameObject player;
    //TEXT格納変数  
    public GameObject text;
    public GameObject Time;

    public GameObject Image;

    public GameObject VideoPlane;
    private float VideoPlay = 0;

    public GameObject limit;

    public GameObject Enemy;
    //Goalしたかどうか判定する
    private bool isGoal = false;

    VideoPlayer video;

    //RestartManager型
    private RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        VideoPlay = 0;
        video = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(VideoPlay==1)
        {
            if (video.isPlaying)
            {
                video.Pause();
            }
            else
            {
                video.Play();
                VideoPlay = 0;
            }
        }
        
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

            Image.SetActive(true);
            VideoPlane.SetActive(true);
            VideoPlay++;

            Destroy(Time.gameObject);

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
