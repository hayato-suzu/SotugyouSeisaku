using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    //�{�^����������GameScene�Ɉڂ�
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("SelectScene");
    }
    //�{�^����������MenuScene�Ɉڂ�
    public void OnClickMenuButton()
    {
        SceneManager.LoadScene("MenuScene");
    }
    //�{�^����������TitleScene�Ɉڂ�
    public void OnClickTitleButton()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
