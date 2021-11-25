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
        //1�b���1�b����Shot�̏������J��Ԃ�
        InvokeRepeating("Shot", 1, 1);
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
        //2�b��ɏ���
        Destroy(Bullets.gameObject, 2);
    }
}
