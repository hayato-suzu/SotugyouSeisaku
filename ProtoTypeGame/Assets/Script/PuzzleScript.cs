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

    [SerializeField]
    [Tooltip("再生するSE")]
    public AudioClip buttonSe;

    //音データの再生装置
    private AudioSource Audio;

    //説明のテキスト
    public Text puzzlemessage;
    //カウントテキスト
    public Text CountText;

    //生成した数のカウント
     int CubeCount = 0;
    //生成できる最大数
    public int CubeCountMax = 2;

    GameObject[] CreateCube = new GameObject[2];

    private void Start()
    {
        PuzzlePanel.SetActive(false);
        Audio = gameObject.AddComponent<AudioSource>();
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
        Audio.PlayOneShot(buttonSe);
    }

    //リセットボタン
    public void ResetButtonClick()
    {
        for(int i = 0;i<CubeCount;i++)
        {
            Destroy(CreateCube[i]);

        }
        CubeCount = 0;
        Audio.PlayOneShot(buttonSe);
    }
    //赤ボタン
    public void RedButtonClick()
    {
        if (CubeCount < CubeCountMax)
        {
            float x = Random.Range(RangeA.position.x, RangeB.position.x);
            float y = Random.Range(RangeA.position.y, RangeB.position.y);
            float z = Random.Range(RangeA.position.z, RangeB.position.z);

            CreateCube[CubeCount] = Instantiate(RedCube, new Vector3(x, y, z), RedCube.transform.rotation);
            CubeCount++;
        }
        Audio.PlayOneShot(buttonSe);
    }
    //青ボタン
    public void BlueButtonClick()
    {

        if (CubeCount < CubeCountMax)
        {
            float x = Random.Range(RangeA.position.x, RangeB.position.x);
            float y = Random.Range(RangeA.position.y, RangeB.position.y);
            float z = Random.Range(RangeA.position.z, RangeB.position.z);

            CreateCube[CubeCount] = Instantiate(BlueCube, new Vector3(x, y, z), BlueCube.transform.rotation);
            CubeCount++;
        }
        Audio.PlayOneShot(buttonSe);

    }
    //緑ボタン
    public void GreenButtonClick()
    {
        if (CubeCount < CubeCountMax)
        {
            float x = Random.Range(RangeA.position.x, RangeB.position.x);
            float y = Random.Range(RangeA.position.y, RangeB.position.y);
            float z = Random.Range(RangeA.position.z, RangeB.position.z);

            CreateCube[CubeCount] = Instantiate(GreenCube, new Vector3(x, y, z), GreenCube.transform.rotation);
            CubeCount++;
        }
        Audio.PlayOneShot(buttonSe);
    }
    //パネルを消すボタン
    public void BackButton()
    {
        PuzzlePanel.SetActive(false);
        Audio.PlayOneShot(buttonSe);
    }

}
