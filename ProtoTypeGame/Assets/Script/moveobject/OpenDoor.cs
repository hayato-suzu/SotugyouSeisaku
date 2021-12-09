using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject openWall;

    public void OnMouseDown()
    {
        StartCoroutine("Open");
    }

    IEnumerator Open()
    {
        for (int i = 0; i < 5; i++)
        {
            openWall.transform.position = openWall.transform.position += new Vector3(1, 0, 0);
            yield return new WaitForSeconds(0.05f);
        }
        //Invoke("Reset", 5.0f);
    }

    //private void Reset()
    //{
    //    for (int i = 0; i < 5; i++)
    //    {
    //        openWall.transform.position = openWall.transform.position -= new Vector3(1, 0, 0);
    //    }
    //}
}
