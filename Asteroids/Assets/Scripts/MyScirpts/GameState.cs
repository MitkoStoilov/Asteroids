using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour {

	// Use this for initialization
	public GameObject health1;
	public GameObject health2;
	public GameObject health3;
	public int HealthBar = 3;

	void Update(){
		Vector3 asd =  GameObject.FindGameObjectWithTag("Enemy").transform.position;
		if(asd.z < 0f && asd.z>-1){
			Destroy(GameObject.FindGameObjectWithTag("Enemy"));
			HealthBar--;
			if(HealthBar==2)
			{
				Destroy(health3);
			}else if(HealthBar == 1)
			{
				Destroy(health1);
			}else if(HealthBar== 0){
				Destroy(health2);
				HealthBar = 3;
				Destroy(GameObject.FindGameObjectWithTag("Player"));
			}
		}
	}
}
