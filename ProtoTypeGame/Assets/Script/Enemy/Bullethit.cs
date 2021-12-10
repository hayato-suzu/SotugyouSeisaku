using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityChan;

public class Bullethit : MonoBehaviour
{
	[SerializeField]
	[Tooltip("���˕Ԃ�����")]
	public float bounceSpeed = 30.0f;

	[SerializeField]
	[Tooltip("���˕Ԃ��P�ʃx�N�g���ɂ�����{��")]
	public float bounceVectorMultiple = 2f;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player")
		{

			// �Փ˂����ʂ́A�ڐG�����_�ɂ�����@���x�N�g�����擾
			Vector3 normal = collision.contacts[0].normal;
			// �Փ˂������x�x�N�g����P�ʃx�N�g���ɂ���
			Vector3 velocity = collision.rigidbody.velocity.normalized;
			// x,z�����ɑ΂��ċt�����̖@���x�N�g�����擾
			velocity += new Vector3(-normal.x * bounceVectorMultiple, 0f, -normal.z * bounceVectorMultiple);
			// �擾�����@���x�N�g���ɒ��˕Ԃ������������āA���˕Ԃ�
			collision.rigidbody.AddForce(velocity * bounceSpeed, ForceMode.Impulse);

			Destroy(this.gameObject);
		}
	}
}
