
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int speed;


	// Update is called once per frame
	void Update () {


		UpdateShootInputs();
		
	
		transform.position += Vector3.forward * Time.deltaTime * -speed;
	}

	private void UpdateShootInputs()
    {

        GetComponent<Weapon>().Shoot();
        
    }
}
