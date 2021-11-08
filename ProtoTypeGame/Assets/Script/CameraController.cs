using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector2 LastMousePosition;

    private float BaseCameraAngle;
    private float BaseCameraDistance;
    private float BaseCameraHeight;
    private float RotaLim = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        BaseCameraAngle = transform.rotation.x;
        BaseCameraDistance = transform.localPosition.z;
        BaseCameraHeight = transform.localPosition.y;
        LastMousePosition = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        MoveCameraAngle();
    }

    private void MoveCameraAngle()
    {
        Vector3 RotaAngle = new Vector3(0.0f, 0.0f, 0.0f);
        Vector3 RotaPosition = new Vector3(0.0f, 0.0f, 0.0f);

        RotaAngle.x = (LastMousePosition.y - Input.mousePosition.y);

        if (transform.rotation.x + RotaAngle.x > BaseCameraAngle + RotaLim)
        {
            RotaAngle.x = BaseCameraAngle + RotaLim;
            //Debug.Log(transform.rotation.x);
            Debug.Log(BaseCameraAngle + RotaLim);
        }
        else if (transform.rotation.x + RotaAngle.x < BaseCameraAngle - RotaLim)
        {
            RotaAngle.x = BaseCameraAngle - RotaLim;
            Debug.Log(BaseCameraAngle - RotaLim);
        }

        transform.Rotate(RotaAngle);
        //Debug.Log(transform.rotation.x);

        RotaPosition.x = transform.localPosition.x;
        RotaPosition.y = -Mathf.Sin(transform.rotation.x) * BaseCameraDistance +BaseCameraHeight;
        RotaPosition.z = Mathf.Cos(transform.rotation.x) * BaseCameraDistance;
        transform.localPosition = RotaPosition;
        /*
        Debug.Log(transform.position.x);
        Debug.Log(transform.position.y);
        Debug.Log(transform.position.z);
        */
        //Debug.Log(transform.localPosition.y);

        LastMousePosition = Input.mousePosition;
    }
}
