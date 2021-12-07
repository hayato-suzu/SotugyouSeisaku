using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class brokenGimick : MonoBehaviour
{
    //warp���object��
    public Text message;
    MeshRenderer mesh;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mesh.material.color = mesh.material.color - new Color32(0, 0, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //text��\������
        message.text = "�ςȉ����苿����...\n�����ړ���������������������Ȃ�";

        StartCoroutine("TextSet");

    }

    IEnumerator TextSet()
    {
        //n�b��ɏ���
        yield return new WaitForSeconds(5.0f);
        StartCoroutine("Destroy");

        message.text = "";
    }

    IEnumerator Destroy()
    {
        for (int i = 0; i < 255; i++)
        {
            mesh.material.color = mesh.material.color - new Color32(0, 0, 0, 1);
            yield return new WaitForSeconds(0.1f);
        }
        //alphe�l��0�ɂȂ��������
        Destroy(this.gameObject);
    }
}
