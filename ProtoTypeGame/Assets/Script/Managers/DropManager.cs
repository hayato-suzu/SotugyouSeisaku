using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropManager : MonoBehaviour
{
    //�i�[����ϐ�
    public GameObject player;
    public GameObject text;

    //RestartManager�^
    private RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        //�C���X�^���X����
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
