using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine("Rote1");
    }

    IEnumerator Rote1()
    {
        for(int i=0;i<90;i++)
        {
            gameObject.transform.Rotate(new Vector3(0, 1, 0));
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(5f);
        StartCoroutine("Rote2");
    }

    IEnumerator Rote2()
    {
        for (int i = 0; i < 90; i++)
        {
            gameObject.transform.Rotate(new Vector3(0, 1, 0));
            yield return new WaitForSeconds(0.01f);
        }

        yield return new WaitForSeconds(5f);
        StartCoroutine("Rote1");
    }
}
