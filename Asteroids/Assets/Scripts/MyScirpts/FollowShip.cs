using UnityEngine;

public class FollowShip : MonoBehaviour {

	public int speed;


	// Update is called once per frame
	void Update () {
		transform.position += Vector3.forward * Time.deltaTime * -speed;
	}

}
