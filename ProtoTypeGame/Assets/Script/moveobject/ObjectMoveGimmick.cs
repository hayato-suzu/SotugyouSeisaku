using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMoveGimmick : MonoBehaviour
{
    private Rigidbody rigidbody;
    private Vector3 BasePosition;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
        BasePosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionStay(Collision collision)
    {
        //プレイヤーが衝突
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Coll");
            //マウスを左クリックしている間動かせるようにする
            if (Input.GetMouseButton(0))
            {
                rigidbody.constraints &= ~RigidbodyConstraints.FreezePositionX;
                rigidbody.constraints &= ~RigidbodyConstraints.FreezePositionZ;
                rigidbody.isKinematic = false;
                
            }
            else
            {
                rigidbody.constraints |= RigidbodyConstraints.FreezePositionX;
                rigidbody.constraints |= RigidbodyConstraints.FreezePositionZ;
                rigidbody.isKinematic = true;
            }
        }

        else if(collision.gameObject.tag != "Ground")
        {
            rigidbody.constraints |= RigidbodyConstraints.FreezePositionX;
            rigidbody.constraints |= RigidbodyConstraints.FreezePositionZ;
            rigidbody.isKinematic = true;
            this.transform.position = BasePosition;
        }
    }
}


