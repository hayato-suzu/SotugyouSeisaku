using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    float seconds;
    private void Update()
    {
        seconds += Time.deltaTime;
        if(seconds >= 5)
        {
            seconds = 0;
            transform.Rotate(new Vector3(0, 90.0f, 0));          
        }
    }
}
