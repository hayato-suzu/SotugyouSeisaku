using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickMoveObject : MonoBehaviour
{
    public GameObject MoveGroundGimmick;
    public GameObject ground;
    public Text text;
    private float count = 0;
    public float textcount=2;
    public float groundcount = 2;

    private void Update()
    {
        text.text = "écÇË"+textcount+"âÒìÆÇ©ÇπÇÈÇÊÅI";
    }

    public void UpButton()
    {
        textcount--;
        StartCoroutine("UP");
    }

    public void LeftButton()
    {
        textcount--;
        StartCoroutine("LEFT");
    }

    public void RightButton()
    {
        textcount--;
        StartCoroutine("RIGHT");
    }

    public void DownButton()
    {
        textcount--;
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
        if (count >= groundcount)
        {
            MoveGroundGimmick.SetActive(false);
            count = 0;
            textcount = 2;
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
        if (count >= groundcount)
        {
            MoveGroundGimmick.SetActive(false);
            count = 0;
            textcount = 2;
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
        if (count >= groundcount)
        {
            MoveGroundGimmick.SetActive(false);
            count = 0;
            textcount = 2;
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
        if (count >= groundcount)
        {
            MoveGroundGimmick.SetActive(false);
            count = 0;
            textcount = 2;
        }
    }
}
