using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    //warpêÊÇÃobjectñº
    public GameObject WarpArea;
    private Vector3 trans;

    // Start is called before the first frame update
    void Start()
    {
        trans = WarpArea.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = trans;
    }
}
