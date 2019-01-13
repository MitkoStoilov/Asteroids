using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyP : MonoBehaviour {

	// Use this for initialization
	public float ProjectileDuration = 5f;
    public float ProjectileVelocity = -15f;
    
	void Start () {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = transform.forward * ProjectileVelocity;
        Destroy(gameObject, ProjectileDuration);
	}
}
