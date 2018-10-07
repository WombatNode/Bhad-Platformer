using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour {
private Transform target;
public int stalllength;
	void Start(){
		target = GameObject.FindGameObjectWithTag("MasterPlayer").GetComponentInParent<Transform>();
	}
	// Update is called once per frame
	void Update () {
		if (target.transform.position.z > -0.01f && target.transform.position.z < 0.01f){
			transform.position = new Vector3(target.position.x, Mathf.Max(target.position.y, 0), -10);
			Debug.Log("zero eh");
			}
		else if (target.transform.position.z > 9.99f && target.transform.position.z < 10.01f){
			transform.position = new Vector3(target.position.x, Mathf.Max(target.position.y, 0), 20);
		}
		else{
			transform.position = target.position + new Vector3(0, 10, 0);
			Debug.Log("not quite nada");
		}
		transform.rotation = Quaternion.LookRotation(target.position - transform.position);
	}
}
