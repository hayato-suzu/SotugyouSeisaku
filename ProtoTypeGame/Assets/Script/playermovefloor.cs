using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovefloor : MonoBehaviour
{
    private Rigidbody rb;
    public float upForce = 100f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(new Vector3(0, upForce, 0));
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (transform.parent == null && col.gameObject.name == "movefloor")
        {
            var emptyObject = new GameObject();
            emptyObject.transform.parent = col.gameObject.transform;
            transform.parent = emptyObject.transform;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (transform.parent != null && col.gameObject.name == "movefloor")
        {
            transform.parent = null;
        }
    }
}
