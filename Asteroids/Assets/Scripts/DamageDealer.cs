using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour {
	public string TagToHit = "Asteroid";
	public string TagToHit1 = "Asteroid";

	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.CompareTag(TagToHit) || collision.gameObject.CompareTag(TagToHit1))
		{
			Destroy(gameObject);
			HitReceiver hitReceiver = collision.gameObject.GetComponent<HitReceiver> ();
			if (hitReceiver) {
				hitReceiver.ReceiveHit (gameObject);

			} else {
				Destroy (collision.gameObject);
			}

		}
	}
}
