using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumppad : MonoBehaviour
{
    [SerializeField] private float jumpForce = 20.0f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(0, jumpForce, 0, ForceMode.Impulse);
        }
    }
}
