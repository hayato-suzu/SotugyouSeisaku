using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleScript : MonoBehaviour
{
    [SerializeField] GameObject PuzzlePanel;

    public Text puzzlemessage;

    private void Start()
    {
        PuzzlePanel.SetActive(false);
    }

    private void OnMouseDown()
    {
        //textを表示する
        puzzlemessage.text = "あいうえお\naaa";
        PuzzlePanel.SetActive(true);
        //StartCoroutine("TextSet");
    }


    public void ResetButtonClick()
    {

    }

    public void RedButtonClick()
    {

    }

    public void BlueButtonClick()
    {

    }

    public void GreenButtonClick()
    {

    }


    //IEnumerator TextSet()
    //{
    //    //n秒後に消す
    //    yield return new WaitForSeconds(5.0f);

    //    puzzlemessage.text = "";
    //}
}
