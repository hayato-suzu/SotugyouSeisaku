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
        //1�b���time�b����Shot�̏������J��Ԃ�
        InvokeRepeating("Shot", 1, time);
    }

    void Shot()
    {
        //�e��C��Ɠ����ꏊ�A���������ɐ�������
        GameObject Bullets = Instantiate(Bullet.gameObject, transform.position, transform.rotation);
        //�e�Ɋ|�����
        Vector3 Force;
        //�e�Ɋ|����͂�@��̑O�����Ɋ|����
        Force = transform.forward * 400;
        //�e�ɗ͂�������
        Bullets.GetComponent<Rigidbody>().AddForce(Force);
        //5�b��ɏ���
        Destroy(Bullets.gameObject, destroytime);
    }
}
