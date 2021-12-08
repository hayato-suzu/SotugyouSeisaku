using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pit : MonoBehaviour
{
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == Player.name)
        {
            Player.GetComponent<CapsuleCollider>().enabled = false;
            Invoke("Exit",0.5f);
        }
    }

    private void Exit()
    {
        //Debug.Log("return");
        Player.GetComponent<CapsuleCollider>().enabled = true;
    }
}
