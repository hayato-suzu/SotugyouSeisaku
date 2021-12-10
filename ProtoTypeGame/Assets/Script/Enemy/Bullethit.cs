using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityChan;

public class Bullethit : MonoBehaviour
{
	[SerializeField]
	[Tooltip("跳ね返す速さ")]
	public float bounceSpeed = 30.0f;

	[SerializeField]
	[Tooltip("跳ね返す単位ベクトルにかける倍数")]
	public float bounceVectorMultiple = 2f;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player")
		{

			// 衝突した面の、接触した点における法線ベクトルを取得
			Vector3 normal = collision.contacts[0].normal;
			// 衝突した速度ベクトルを単位ベクトルにする
			Vector3 velocity = collision.rigidbody.velocity.normalized;
			// x,z方向に対して逆向きの法線ベクトルを取得
			velocity += new Vector3(-normal.x * bounceVectorMultiple, 0f, -normal.z * bounceVectorMultiple);
			// 取得した法線ベクトルに跳ね返す速さをかけて、跳ね返す
			collision.rigidbody.AddForce(velocity * bounceSpeed, ForceMode.Impulse);

			Destroy(this.gameObject);
		}
	}
}
