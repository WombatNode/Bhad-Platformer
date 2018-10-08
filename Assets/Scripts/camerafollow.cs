using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour {
private Transform target;
Vector3 flat = new Vector3(0, 0, -9);
Vector3 vert = new Vector3(0, 9, 0);
public GeneralController controller;
float i;
bool orientation;
	void Start(){
		target = GameObject.FindGameObjectWithTag("MasterPlayer").GetComponentInParent<Transform>();
		i = 1;
		controller = GameObject.Find("Initialiser").GetComponent<GeneralController>();
		orientation = true;
	}
	// Update is called once per frame
	void Update () {
		if (controller.playing == 'p' || controller.playing == 'd'){
			if (!orientation){
				orientation = true;
				i = 0;
			}
		}
		else{
			if (orientation){
				orientation = false;
				i = 0;
			}
		}
		if (orientation){
			transform.position = target.position + Vector3.Slerp(vert, flat, i);
		}else{
			transform.position = target.position + Vector3.Slerp(flat, vert, i);
		}
		if (i < 1){
			i += 0.0333f;
		}
		transform.rotation = Quaternion.LookRotation(target.position - transform.position);
	}
}
