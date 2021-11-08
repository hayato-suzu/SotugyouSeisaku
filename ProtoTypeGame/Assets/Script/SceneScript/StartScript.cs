using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    //ボタンを押すとGameSceneに移る
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("SelectScene");
    }
    //ボタンを押すとMenuSceneに移る
    public void OnClickMenuButton()
    {
        SceneManager.LoadScene("MenuScene");
    }
    //ボタンを押すとTitleSceneに移る
    public void OnClickTitleButton()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
