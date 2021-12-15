using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class brokenGimick : MonoBehaviour
{
    MeshRenderer mesh;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mesh.material.color = mesh.material.color - new Color32(0, 0, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine("Destroy");
    }

    IEnumerator Destroy()
    {
        for (int i = 0; i < 255; i++)
        {
            mesh.material.color = mesh.material.color - new Color32(0, 0, 0, 1);
            yield return new WaitForSeconds(0.001f);
        }
        //alphe’l‚ª0‚É‚È‚Á‚½‚çÁ‚·
        Destroy(this.gameObject);
    }
}
