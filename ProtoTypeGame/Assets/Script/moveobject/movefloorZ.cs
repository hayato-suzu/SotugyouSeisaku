using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movefloorZ : MonoBehaviour
{
    int counter = 0;
    public float move = 0.01f;

    void Update()
    {
        Vector3 p = new Vector3(0, 0, move);
        transform.Translate(p);
        counter++;

        if (counter == 1500)
        {
            counter = 0;
            move *= -1;
        }
    }
}
