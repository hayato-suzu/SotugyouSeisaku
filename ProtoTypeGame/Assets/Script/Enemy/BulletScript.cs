using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityChan;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BulletScript : MonoBehaviour
{
    public GameObject Bullet;
    public float time = 1.0f;
    public float destroytime = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        //1秒後にtime秒ごとShotの処理を繰り返す
        InvokeRepeating("Shot", 1, time);
    }

    void Shot()
    {
        //弾を砲台と同じ場所、同じ向きに生成する
        GameObject Bullets = Instantiate(Bullet.gameObject, transform.position, transform.rotation);
        //弾に掛ける力
        Vector3 Force;
        //弾に掛ける力を法大の前方向に掛ける
        Force = transform.forward * 400;
        //弾に力をかける
        Bullets.GetComponent<Rigidbody>().AddForce(Force);
        //5秒後に消す
        Destroy(Bullets.gameObject, destroytime);
    }
}
