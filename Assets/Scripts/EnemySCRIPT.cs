using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySCRIPT : MonoBehaviour {
public Transform target;
public float speed;
public Rigidbody rb;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (target.position.x > transform.position.x){
			transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
		} 
		if (target.position.x < transform.position.x){
			transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
		} 
		rb.velocity = new Vector3(0, rb.velocity.y, 0);
	}
}
