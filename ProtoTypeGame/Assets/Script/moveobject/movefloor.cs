using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movefloor : MonoBehaviour
{
    int counter = 0;
    float move = 0.01f;

    void Update()
    {
        Vector3 p = new Vector3(move, 0, 0);
        transform.Translate(p);
        counter++;

        if (counter == 1500)
        {
            counter = 0;
            move *= -1;
        }
    }
}
