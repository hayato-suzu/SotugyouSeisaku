using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class brokenGimick : MonoBehaviour
{
    //warp先のobject名
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
        //textを表示する
        message.text = "足場が崩れ始めた！";

        StartCoroutine("TextSet");

    }

    IEnumerator TextSet()
    {
        //n秒後に消す
        yield return new WaitForSeconds(5.0f);
        StartCoroutine("Destroy");

        message.text = "";
    }

    IEnumerator Destroy()
    {
        for (int i = 0; i < 255; i++)
        {
            mesh.material.color = mesh.material.color - new Color32(0, 0, 0, 1);
            yield return new WaitForSeconds(0.05f);
        }
        //alphe値が0になったら消す
        Destroy(this.gameObject);
    }
}
