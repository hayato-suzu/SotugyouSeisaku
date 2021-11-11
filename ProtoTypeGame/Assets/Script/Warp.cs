using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    //warpêÊÇÃobjectñº
    public GameObject Cube2;
    private Vector3 trans;

    // Start is called before the first frame update
    void Start()
    {
        trans = Cube2.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = trans;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 2, 0));
    }
}
