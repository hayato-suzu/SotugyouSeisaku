using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMoveObject : MonoBehaviour
{
    public GameObject MoveGroundGimmick;
    public GameObject ground;
    //private Rigidbody rigidbody;

    private void Start()
    {
        //rigidbody = ground.GetComponent<Rigidbody>();
    }

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

    public void FinishButton()
    {
        MoveGroundGimmick.SetActive(false);
    }

    IEnumerator UP()
    {
        for (int i = 0; i < 5; i++)
        {
            //rigidbody.AddForce(new Vector3(0.0f, 0.0f, 100.0f));
            ground.transform.position = ground.transform.position += new Vector3(0, 0, 1);
            yield return new WaitForSeconds(0.05f);
        }
    }

    IEnumerator LEFT()
    {
        for (int i = 0; i < 5; i++)
        {
            //rigidbody.AddForce(new Vector3(-100.0f, 0.0f, 0.0f));
            ground.transform.position = ground.transform.position += new Vector3(-1, 0, 0);
            yield return new WaitForSeconds(0.05f);
        }
    }

    IEnumerator RIGHT()
    {
        for (int i = 0; i < 5; i++)
        {
            //rigidbody.AddForce(new Vector3(100.0f, 0.0f,0.0f));
            ground.transform.position = ground.transform.position += new Vector3(1, 0, 0);
            yield return new WaitForSeconds(0.05f);
        }
    }

    IEnumerator DOWN()
    {
        for (int i = 0; i < 5; i++)
        {
            //rigidbody.AddForce(new Vector3(0.0f, 0.0f, -100.0f));
            ground.transform.position = ground.transform.position += new Vector3(0, 0, -1);
            yield return new WaitForSeconds(0.05f);
        }
    }
}
