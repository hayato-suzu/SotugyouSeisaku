using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class brokenGimick : MonoBehaviour
{
    //warpæ‚Ìobject–¼
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
        //text‚ğ•\¦‚·‚é
        message.text = "•Ï‚È‰¹‚ª–Â‚è‹¿‚¢‚½...\n‘‚­ˆÚ“®‚µ‚½•û‚ª‚¢‚¢‚©‚à‚µ‚ê‚È‚¢";

        StartCoroutine("TextSet");

    }

    IEnumerator TextSet()
    {
        //n•bŒã‚ÉÁ‚·
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
        //alphe’l‚ª0‚É‚È‚Á‚½‚çÁ‚·
        Destroy(this.gameObject);
    }
}
