using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //30•b‚Åˆê‰ñ“]
        float rotateValue = 12 * Time.deltaTime;

        transform.Rotate(new Vector3(0f, rotateValue, 0f));
    }
}
