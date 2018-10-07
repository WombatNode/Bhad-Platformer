using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
public Rigidbody rb;
public float speed;
public float jumpspeed;
public GameObject player;

public bool canjump;
private Vector3 pausemovedist;
public GeneralController controller;
	// Update is called once per frame
	void Start () {
		controller = GameObject.Find("Initialiser").GetComponent<GeneralController>();
	}
	void FixedUpdate () {
		if (controller.playing == 'p' || controller.playing == 'f'){
			rb.AddForce(new Vector3(0,-18,0));
			if (Input.GetKey("right")){
				if (rb.velocity.x < 6){
					rb.velocity += new Vector3(0.6f, 0, 0);
				}			
				if (rb.velocity.x < 0){
					rb.velocity += new Vector3(1.2f, 0, 0);
				}
			}
			if (Input.GetKey("left")){
				if (rb.velocity.x > -6){
					rb.velocity -= new Vector3(0.6f, 0, 0);
				}		
				if (rb.velocity.x > 0){
					rb.velocity -= new Vector3(1.2f, 0, 0);
				}
			}

			if (controller.playing == 'f'){
				if (Input.GetKey("up")){
					if (rb.velocity.z < 6){
						rb.velocity += new Vector3(0, 0, 0.6f);
					}		
					if (rb.velocity.z < 0){
						rb.velocity += new Vector3(0, 0, 1.2f);
					}
				}
				if (Input.GetKey("down")){
					if (rb.velocity.z > -6){
						rb.velocity -= new Vector3(0, 0, 0.6f);
					}		
					if (rb.velocity.z > 0){
						rb.velocity -= new Vector3(0, 0, 1.2f);
					}
				}

			}
			else {
				rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 0);
				if (transform.position.z > 5){
					transform.position = new Vector3(transform.position.x, transform.position.y, 10);
				}else{
					transform.position = new Vector3(transform.position.x, transform.position.y, 0);
				}
				if (Input.GetKey("up") && canjump){
					rb.velocity = new Vector3(rb.velocity.x, 10, rb.velocity.z);
				}
			}
		}
		else if (controller.playing == 'd'){
			Debug.Log("big banana");
			if (controller.startmove){
				pausemovedist = (controller.destination - transform.position) / 9;
				controller.startmove = false;
			}
			transform.position += pausemovedist;
		}
	}
	void OnCollisionStay(Collision collider)
    {
        //if (collider.gameObject.tag == "Floor"){
			canjump = true;
		//}
    }
	void OnCollisionExit(Collision collider){
		//if (collider.gameObject.tag == "Floor"){
			canjump = false;
		//}
	}
}
