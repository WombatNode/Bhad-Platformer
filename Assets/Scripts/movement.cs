using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
public Rigidbody rb;
public float speed;
public float jumpspeed;
public bool canjump;
private Vector3 pausemovedist;
public GeneralController controller;
	// Update is called once per frame
	void Start () {
		controller = GameObject.Find("Initialiser").GetComponent<GeneralController>();
	}
	void FixedUpdate () {
		if (controller.playing == 'p'){
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
			if (Input.GetKey("up") && canjump){
				rb.velocity = new Vector3(rb.velocity.x, 10, rb.velocity.z);
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
