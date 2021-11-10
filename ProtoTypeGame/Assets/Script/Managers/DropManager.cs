using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropManager : MonoBehaviour
{
    //Ši”[‚·‚é•Ï”
    public GameObject player;
    public GameObject text;

    //RestartManagerŒ^
    private RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        //ƒCƒ“ƒXƒ^ƒ“ƒX¶¬
        restart = new RestartManager(player, text);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < -13)
        {
            restart.PrintGameOver();
        }

        if(restart.IsGameOver() && Input.GetMouseButton(0))
        {
            restart.Restart();
        }
    }
}
