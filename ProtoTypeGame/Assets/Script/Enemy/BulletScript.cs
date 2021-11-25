using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityChan;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BulletScript : MonoBehaviour
{
    public GameObject Bullet;

    // Start is called before the first frame update
    void Start()
    {
        //1•bŒã‚É1•b‚²‚ÆShot‚Ìˆ—‚ğŒJ‚è•Ô‚·
        InvokeRepeating("Shot", 1, 1);
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
        //2•bŒã‚ÉÁ‚·
        Destroy(Bullets.gameObject, 2);
    }
}
