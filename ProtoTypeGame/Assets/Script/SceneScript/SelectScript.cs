using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectScript : MonoBehaviour
{
    //�{�^���������Ɠ�Փx�m�[�}����GameScene�Ɉڂ�
    public void OnClickNormalButton()
    {
        int value = Random.Range(1, 3);

        SceneManager.LoadScene("GameSceneN" + value.ToString());
    }


    //�{�^���������Ɠ�Փx�n�[�h��GameScene�Ɉڂ�
    public void OnClickHardButton()
    {
        int value = Random.Range(1, 3);

        SceneManager.LoadScene("GameSceneH" + value.ToString());
    }
}
