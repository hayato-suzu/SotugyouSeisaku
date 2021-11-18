using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleScript : MonoBehaviour
{
    //�p�l���i�[�ϐ�
    [SerializeField] GameObject PuzzlePanel;
    

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

    public Text puzzlemessage;

    private void Start()
    {
        PuzzlePanel.SetActive(false);
    }

    private void OnMouseDown()
    {
        //text��\������
        puzzlemessage.text = "����������\naaa";
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
    //    //n�b��ɏ���
    //    yield return new WaitForSeconds(5.0f);

    //    puzzlemessage.text = "";
    //}
}
