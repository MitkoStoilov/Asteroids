using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour {

	public GameObject Spawn;
	public GameObject Spawn1;
	public GameObject Spawn2;
 
	// Use this for initialization
	void Start () {
		
		StartCoroutine(TheSequence());
	}
	IEnumerator TheSequence(){
		yield return new WaitForSeconds (10);
		Spawn.GetComponent<TimedSpawn>().enabled = true;
		Spawn1.GetComponent<TimedSpawn>().enabled = true;
		Spawn2.GetComponent<TimedSpawn>().enabled = true;
		
		
	

	}
}
