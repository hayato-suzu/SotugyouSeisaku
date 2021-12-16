using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityChan;

public class BulletHitPlayer : MonoBehaviour
{
	public float WaitTime = 0.5f;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Bullet")
		{
			StartCoroutine("DisableKeyInputCoroutine");
		}
	}

	IEnumerator DisableKeyInputCoroutine()
	{
		this.gameObject.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
		this.gameObject.GetComponent<Animator>().enabled = false;

		yield return new WaitForSeconds(WaitTime);

        // �L�[���͂̃R���|�[�l���g��L���ɖ߂�
        this.gameObject.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = true;
        // �A�j���[�^�[��L���ɖ߂�
        this.gameObject.GetComponent<Animator>().enabled = true;
    }
}
