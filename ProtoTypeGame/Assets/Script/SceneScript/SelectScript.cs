using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectScript : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    //ボタンを押すと難易度ノーマルのGameSceneに移る
    public void OnClickNormalButton()
    {
        int value = Random.Range(1, 3);

        SceneManager.LoadScene("GameSceneN" + value.ToString());
    }


    //ボタンを押すと難易度ハードのGameSceneに移る
    public void OnClickHardButton()
    {
        int value = Random.Range(1, 3);

        SceneManager.LoadScene("GameSceneH" + value.ToString());
    }
}
