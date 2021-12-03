using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smaller : MonoBehaviour
{
    [Tooltip("何％ごと小さくするかの数値")] public float Scale_rate;
    [Tooltip("最終割合")] public float Scale_min;



    Vector3 Scale_sub;
    


    // Start is called before the first frame update
    void Start()
    {
        //パーセントに変換
        Scale_min = Scale_min / 100;
        Scale_rate = Scale_rate / 100;
        //引くVector3に変換
        Scale_sub= new Vector3(this.transform.localScale.x * Scale_rate,0, this.transform.localScale.z*Scale_rate);
        //xの最小値に変換
        Scale_min = this.transform.localScale.x * Scale_min;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            //上に乗っているか and　xの最小値<引いた後のxの数値
            if (collision.transform.position.y > this.transform.position.y && Scale_min < this.transform.localScale.x - Scale_sub.x)
            {
                
                this.transform.localScale = this.transform.localScale - Scale_sub;
            }
        }
        
        
    }

}
