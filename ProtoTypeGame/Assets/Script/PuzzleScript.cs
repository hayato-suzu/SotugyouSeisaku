using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleScript : MonoBehaviour
{
    [SerializeField]
    [Tooltip("パネル格納変数")]
    GameObject PuzzlePanel;
    
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

    //説明のテキスト
    public Text puzzlemessage;
    //カウントテキスト
    public Text CountText;

    //生成した数のカウント
     int CubeCount = 0;
    //生成できる最大数
    private int CubeCountMax = 2;

    private void Start()
    {
        PuzzlePanel.SetActive(false);
    }

    private void Update()
    {
        //生成したときのテキスト更新
        CountText.text = "あと" + (CubeCountMax - CubeCount) + "個";
    }

    private void OnMouseDown()
    {
        //textを表示する
        puzzlemessage.text = "二個まで生成できます";
        CountText.text = "あと" + CubeCountMax + "個";
        PuzzlePanel.SetActive(true);
        //StartCoroutine("TextSet");
    }

    //リセットボタン
    public void ResetButtonClick()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("CreateCube");
        foreach(GameObject Cube in objects)
        {
            Destroy(Cube);
            CubeCount = 0;
        }
    }
    //赤ボタン
    public void RedButtonClick()
    {
        if (CubeCount < CubeCountMax)
        {
            float x = Random.Range(RangeA.position.x, RangeB.position.x);
            float y = Random.Range(RangeA.position.y, RangeB.position.y);
            float z = Random.Range(RangeA.position.z, RangeB.position.z);

            Instantiate(RedCube, new Vector3(x, y, z), RedCube.transform.rotation);
            CubeCount++;
        }
    }
    //青ボタン
    public void BlueButtonClick()
    {

        if (CubeCount < CubeCountMax)
        {
            float x = Random.Range(RangeA.position.x, RangeB.position.x);
            float y = Random.Range(RangeA.position.y, RangeB.position.y);
            float z = Random.Range(RangeA.position.z, RangeB.position.z);

            Instantiate(BlueCube, new Vector3(x, y, z), BlueCube.transform.rotation);
            CubeCount++;
        }
    }
    //緑ボタン
    public void GreenButtonClick()
    {
        if (CubeCount < CubeCountMax)
        {
            float x = Random.Range(RangeA.position.x, RangeB.position.x);
            float y = Random.Range(RangeA.position.y, RangeB.position.y);
            float z = Random.Range(RangeA.position.z, RangeB.position.z);

            Instantiate(GreenCube, new Vector3(x, y, z), GreenCube.transform.rotation);
            CubeCount++;
        }
    }
    //パネルを消すボタン
    public void BackButton()
    {
        PuzzlePanel.SetActive(false);
    }

}
