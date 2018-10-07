using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadCamera : MonoBehaviour {
public float i;
public Vector3 pos1;
public Vector3 pos2;
public Transform target;
public Vector3 pos1b = new Vector3(10, 0, 0);
public Vector3 pos2b = new Vector3(0, 10, 0);

public bool dir = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		pos1 = target.transform.position + pos1b;
		pos2 = target.transform.position + pos2b;
		if (Input.GetKey("a") && dir){
			dir = !dir;
			i = 0;
		}
		if (Input.GetKey("s") && !dir){
			dir = !dir;
			i = 0;
		}
		if (dir){
			transform.position = Vector3.Slerp(pos1b, pos2b, i) + target.transform.position;
		}else{
			transform.position = Vector3.Slerp(pos2b, pos1b, i) + target.transform.position;
		}
		if (i < 1){
			Debug.Log("WHAHAHAHAHA");
			i += 0.1f;
		}
		transform.rotation = Quaternion.LookRotation(target.transform.position - transform.position);
	}
}
