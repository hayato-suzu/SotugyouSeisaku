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
        //1•bŒã‚Étime•b‚²‚ÆShot‚Ìˆ—‚ğŒJ‚è•Ô‚·
        InvokeRepeating("Shot", 1, time);
    }

    void Shot()
    {
        //’e‚ğ–C‘ä‚Æ“¯‚¶êŠA“¯‚¶Œü‚«‚É¶¬‚·‚é
        GameObject Bullets = Instantiate(Bullet.gameObject, transform.position, transform.rotation);
        //’e‚ÉŠ|‚¯‚é—Í
        Vector3 Force;
        //’e‚ÉŠ|‚¯‚é—Í‚ğ–@‘å‚Ì‘O•ûŒü‚ÉŠ|‚¯‚é
        Force = transform.forward * 400;
        //’e‚É—Í‚ğ‚©‚¯‚é
        Bullets.GetComponent<Rigidbody>().AddForce(Force);
        //5•bŒã‚ÉÁ‚·
        Destroy(Bullets.gameObject, destroytime);
    }
}
