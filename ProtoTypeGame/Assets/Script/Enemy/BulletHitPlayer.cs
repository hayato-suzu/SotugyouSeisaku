using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityChan;

public class BulletHitPlayer : MonoBehaviour
{
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

		yield return new WaitForSeconds(0.01f);
	}
}
