using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropManager : MonoBehaviour
{
    //格納する変数
    public GameObject player;
    public GameObject text;

    //-に設定する
    public float Drop = -13;

    //RestartManager型
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
        if (player.transform.position.y < Drop)
        {
            restart.PrintGameOver();
        }

        if(restart.IsGameOver() && Input.GetMouseButton(0))
        {
            restart.Restart();
        }
    }
}
