﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour {
private bool opening;
private Vector3 place;
public GameObject player;
public nextlevel Nextlevel;
private int i;
	// Use this for initialization
	void Start () {
		opening = false;
		i = 0;
		player = GameObject.FindGameObjectWithTag("Player");
	}
	void OnTriggerStay () {
		if (Input.GetKey("up") && player.GetComponentInParent<movement>().canjump && !opening){
			opening = true;
			Debug.Log("opendoor");
			place = transform.position;
		}
	}
	void Update(){
		if (opening){
			if (i < 18){
				transform.Rotate(new Vector3(0, -5, 0));
				i++;
				player.GetComponentInParent<Rigidbody>().velocity = new Vector3(0, 0, 0);
				transform.position = place + new Vector3(0, 0, Mathf.Sin(i * Mathf.Deg2Rad * 5));
				//Disable controls, remove all velocity?
			}
			else if (i == 18){
				//trigger next level
				Nextlevel.NextLevel();
			}
		}
	}
}
