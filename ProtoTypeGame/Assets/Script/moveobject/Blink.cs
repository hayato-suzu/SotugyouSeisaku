using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    MeshRenderer mesh;

    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mesh.material.color = mesh.material.color - new Color32(0, 0, 0, 0);
        StartCoroutine("Blinking");
    }

    IEnumerator Blinking()
    {
        for (int i = 0; i < 255; i++)
        {
            mesh.material.color = mesh.material.color - new Color32(0, 0, 0, 1);
            yield return new WaitForSeconds(0.01f);
        }
        StartCoroutine("Appearance");
    }

    IEnumerator Appearance()
    {
        for (int k = 0; k < 255; k++)
        {
            mesh.material.color = mesh.material.color + new Color32(0, 0, 0, 1);
            yield return new WaitForSeconds(0.01f);
        }
        StartCoroutine("Blinking");
    }
}
