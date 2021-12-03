using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovefloor : MonoBehaviour
{
    private Rigidbody rb;
    public float upForce = 100f;
    public GameObject MoveFloor;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (transform.parent == null && col.gameObject.name == MoveFloor.name)
        {
            var emptyObject = new GameObject();
            emptyObject.transform.parent = col.gameObject.transform;
            transform.parent = emptyObject.transform;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (transform.parent != null && col.gameObject.name == MoveFloor.name)
        {
            transform.parent = null;
        }
    }
}
