using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMoveObject : MonoBehaviour
{
    public GameObject MoveGroundGimmick;
    public GameObject ground;
    private float count = 0;

    public void UpButton()
    {
        StartCoroutine("UP");
    }

    public void LeftButton()
    {
        StartCoroutine("LEFT");
    }

    public void RightButton()
    {
        StartCoroutine("RIGHT");
    }

    public void DownButton()
    {
        StartCoroutine("DOWN");
    }

    IEnumerator UP()
    {
        for (int i = 0; i < 5; i++)
        {
            ground.transform.position = ground.transform.position += new Vector3(0, 0, 1);
            yield return new WaitForSeconds(0.05f);
        }
        count++;
        if (count >= 2)
        {
            MoveGroundGimmick.SetActive(false);
            count = 0;
        }
    }

    IEnumerator LEFT()
    {
        for (int i = 0; i < 5; i++)
        {
            ground.transform.position = ground.transform.position += new Vector3(-1, 0, 0);
            yield return new WaitForSeconds(0.05f);
        }
        count++;
        if (count >= 2)
        {
            MoveGroundGimmick.SetActive(false);
            count = 0;
        }
    }

    IEnumerator RIGHT()
    { 
        for (int i = 0; i < 5; i++)
        {
            ground.transform.position = ground.transform.position += new Vector3(1, 0, 0);
            yield return new WaitForSeconds(0.05f);
        }
        count++;
        if (count >= 2)
        {
            MoveGroundGimmick.SetActive(false);
            count = 0;
        }
    }

    IEnumerator DOWN()
    {
        for (int i = 0; i < 5; i++)
        {
            ground.transform.position = ground.transform.position += new Vector3(0, 0, -1);
            yield return new WaitForSeconds(0.05f);
        }
        count++;
        if (count >= 2)
        {
            MoveGroundGimmick.SetActive(false);
            count = 0;
        }
    }
}
