using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]

public class ExtraGravity : MonoBehaviour
{
    //0Ç…Ç∑ÇÈÇ∆ñ≥èdóÕ
    public float MultiPlayer = 1f;

    private Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.AddForce((MultiPlayer - 1f) * Physics.gravity, ForceMode.Acceleration);
    }
}
