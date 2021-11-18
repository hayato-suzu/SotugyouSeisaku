using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleScript : MonoBehaviour
{
    //パネル格納変数
    [SerializeField] GameObject PuzzlePanel;
    

    [SerializeField]
    [Tooltip("赤のプレハブ")]
    public GameObject RedCube;

    [SerializeField]
    [Tooltip("青のプレハブ")]
    public GameObject BlueCube;

    [SerializeField]
    [Tooltip("緑のプレハブ")]
    public GameObject GreenCube;
   
    [SerializeField]
    [Tooltip("生成する範囲A")]
    public Transform RangeA;

    [SerializeField]
    [Tooltip("生成する範囲B")]
    public Transform RangeB;

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
        
        Instantiate(RedCube, new Vector3(1.0f, 1.0f, 122.0f), RedCube.transform.rotation);
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
