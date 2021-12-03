using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pit : MonoBehaviour
{
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == Player.name)
        {
            Player.GetComponent<CapsuleCollider>().enabled = false;
        }
    }
}
