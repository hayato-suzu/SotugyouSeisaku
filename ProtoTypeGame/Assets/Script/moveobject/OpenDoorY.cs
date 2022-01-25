using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorY : MonoBehaviour
{
    public GameObject openWall;
    public AudioClip se;

    public void OnMouseDown()
    {
        StartCoroutine("Open");
    }

    IEnumerator Open()
    {
        AudioSource.PlayClipAtPoint(se, transform.position);
        for (int i = 0; i < 5; i++)
        {
            //YŽ²
            openWall.transform.position = openWall.transform.position += new Vector3(0, 1, 0);
            yield return new WaitForSeconds(0.05f);
        }
    }
}
