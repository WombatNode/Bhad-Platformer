using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour {
private bool opening;
private Vector3 place;
public GameObject player;
public nextlevel Nextlevel;
public camerafollow maincamerafollow;
private int i;
public GeneralController controller;
	// Use this for initialization
	void Start () {
		opening = false;
		i = 0;
		player = GameObject.FindGameObjectWithTag("Player");
		controller = GameObject.Find("Initialiser").GetComponent<GeneralController>();
		maincamerafollow = GameObject.Find("Main Camera").GetComponent<camerafollow>();

	}
	void OnTriggerStay (Collider collider) {
		if (Input.GetKey("z") && player.GetComponentInParent<movement>().canjump && !opening && collider.tag == "Player"){
			opening = true;
			place = transform.position;
			maincamerafollow.stuck = true;
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
			if (i == 1){
				controller.playing = 'd';
				controller.destination = transform.position + new Vector3(0, 1, 0);
				controller.startmove = true;
			}
			if (i == 10){
				//Trigger Next Level
				Nextlevel.NextLevel();
				controller.startmove = true;
				controller.destination += new Vector3(0, 0, 1);
			}
		}
	}
}
