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

    [SerializeField]
    [Tooltip("�Đ�����SE")]
    public AudioClip buttonSe;

    //���f�[�^�̍Đ����u
    private AudioSource Audio;

    //�����̃e�L�X�g
    public Text puzzlemessage;
    //�J�E���g�e�L�X�g
    public Text CountText;

    //�����������̃J�E���g
     int CubeCount = 0;
    //�����ł���ő吔
    public int CubeCountMax = 2;

    GameObject[] CreateCube = new GameObject[2];

    private void Start()
    {
        PuzzlePanel.SetActive(false);
        Audio = gameObject.AddComponent<AudioSource>();
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
        Audio.PlayOneShot(buttonSe);
    }

    //���Z�b�g�{�^��
    public void ResetButtonClick()
    {
        for(int i = 0;i<CubeCount;i++)
        {
            Destroy(CreateCube[i]);

        }
        CubeCount = 0;
        Audio.PlayOneShot(buttonSe);
    }
    //�ԃ{�^��
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
    //�{�^��
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
    //�΃{�^��
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
    //�p�l���������{�^��
    public void BackButton()
    {
        PuzzlePanel.SetActive(false);
        Audio.PlayOneShot(buttonSe);
    }

}
