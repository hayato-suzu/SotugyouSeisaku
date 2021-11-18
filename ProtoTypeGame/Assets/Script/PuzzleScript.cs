using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleScript : MonoBehaviour
{
    [SerializeField]
    [Tooltip("�p�l���i�[�ϐ�")]
    GameObject PuzzlePanel;
    
    [SerializeField]
    [Tooltip("�Ԃ̃v���n�u")]
    public GameObject RedCube;

    [SerializeField]
    [Tooltip("�̃v���n�u")]
    public GameObject BlueCube;

    [SerializeField]
    [Tooltip("�΂̃v���n�u")]
    public GameObject GreenCube;
   
    [SerializeField]
    [Tooltip("��������͈�A")]
    public Transform RangeA;

    [SerializeField]
    [Tooltip("��������͈�B")]
    public Transform RangeB;

    //�����̃e�L�X�g
    public Text puzzlemessage;
    //�J�E���g�e�L�X�g
    public Text CountText;

    //�����������̃J�E���g
     int CubeCount = 0;
    //�����ł���ő吔
    private int CubeCountMax = 2;

    private void Start()
    {
        PuzzlePanel.SetActive(false);
    }

    private void Update()
    {
        //���������Ƃ��̃e�L�X�g�X�V
        CountText.text = "����" + (CubeCountMax - CubeCount) + "��";
    }

    private void OnMouseDown()
    {
        //text��\������
        puzzlemessage.text = "��܂Ő����ł��܂�";
        CountText.text = "����" + CubeCountMax + "��";
        PuzzlePanel.SetActive(true);
        //StartCoroutine("TextSet");
    }

    //���Z�b�g�{�^��
    public void ResetButtonClick()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("CreateCube");
        foreach(GameObject Cube in objects)
        {
            Destroy(Cube);
            CubeCount = 0;
        }
    }
    //�ԃ{�^��
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
    //�{�^��
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
    //�΃{�^��
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
    //�p�l���������{�^��
    public void BackButton()
    {
        PuzzlePanel.SetActive(false);
    }

}
