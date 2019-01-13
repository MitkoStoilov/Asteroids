using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour {
	public GameObject Cam;
	public GameObject Cam2;
	public GameObject MainCam;  
	// Use this for initialization
	void Start () {
		StartCoroutine(TheSequence());
	}
	IEnumerator TheSequence(){
		yield return new WaitForSeconds (5);
		Cam2.GetComponent<Camera>().enabled = true;
		Cam2.SetActive(true);
		Cam.SetActive(false);
		Cam.GetComponent<Camera>().enabled = false;
		yield return new WaitForSeconds (4);
		MainCam.GetComponent<Camera>().enabled = true;
		MainCam.SetActive(true);
		Cam2.SetActive(false);
		Cam2.GetComponent<Camera>().enabled = false;

	}

}
