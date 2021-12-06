using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mystery : MonoBehaviour
{
    private int num;
    private int count;
    private Quaternion targetRot;

    void Update()
    {
        count += 1;

        if (count % 500 == 0)
        {
            num = (num + 1) % 4;
        }

        var step = Time.deltaTime * 30f;

        targetRot = Quaternion.AngleAxis(90 * num, Vector3.up);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRot, step);
    }
}
