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
        //textÇï\é¶Ç∑ÇÈ
        puzzlemessage.text = "Ç†Ç¢Ç§Ç¶Ç®\naaa";
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
    //    //nïbå„Ç…è¡Ç∑
    //    yield return new WaitForSeconds(5.0f);

    //    puzzlemessage.text = "";
    //}
}
