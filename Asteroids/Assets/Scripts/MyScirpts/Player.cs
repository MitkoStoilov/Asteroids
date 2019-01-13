using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public int speed; 
	float smooth = 5.0f;
    float tiltAngle = -35.0f;

	// Update is called once per frame
	void OnDestroy()
    {
        //AsteroidSpawner.Instance.UnregisterPlayer(gameObject);
		GameStateController.Instance.OnPlayerDied ();
    }
	void Update () {

		//transform.position += Vector3.forward * Time.deltaTime * speed;
		UpdateShootInputs();
		if(Input.GetKey("d")){
			transform.position += Vector3.right * Time.deltaTime * 8;
		}

		if(Input.GetKey("a")){
			transform.position += Vector3.left * Time.deltaTime * 8;
		}
		
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
		Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);

        transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);
	}

	private void UpdateShootInputs()
    {
        if (Input.GetButton("Fire1"))
        {
            GetComponent<Weapon>().Shoot();
        }
    }

}
