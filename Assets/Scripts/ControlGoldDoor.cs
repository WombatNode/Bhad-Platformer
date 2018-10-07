using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGoldDoor : MonoBehaviour {
public float i = 0;
public float change = 1;
public GameObject player;
private Rigidbody playerrb;
public int itarget;
public GeneralController controller;
public Vector3 startlocation;
	// Use this for initialization
	void Start () {
		startlocation = transform.position;
		player = GameObject.FindGameObjectWithTag("MasterPlayer");
		transform.rotation = Quaternion.Euler(0, 0, 0);
		controller = GameObject.Find("Initialiser").GetComponent<GeneralController>();
		playerrb = player.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (i <= 90){
			transform.rotation = Quaternion.Euler(new Vector3(i, 0, 0));
			transform.position = new Vector3(startlocation.x, 4.75f * Mathf.Cos(Mathf.Deg2Rad * i) + startlocation.y, startlocation.z + 4.25f * (Mathf.Sin(Mathf.Deg2Rad * i) - 1));
		}
		if (90 < i && i <= 180){
			transform.rotation = Quaternion.Euler(new Vector3(i, 0, 0));
			transform.position = new Vector3(startlocation.x, 4.75f * Mathf.Cos(Mathf.Deg2Rad * (180 - i)) + startlocation.y, startlocation.z + -4.25f * (Mathf.Sin(Mathf.Deg2Rad * (180 - i)) - 1));
		}
		if (itarget > i){
			i += 3;
		}
		if (itarget < i){
			i -= 3;
		}
		if (player.transform.position.z < 0 && itarget == 90){
			player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, 0);
			itarget = 0;
			playerrb.velocity = new Vector3(playerrb.velocity.x, playerrb.velocity.y, 0);
			controller.playing = 'p';
		}
		if (player.transform.position.z > 10 && itarget == 90){
			player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, 10);
			itarget = 180;
			playerrb.velocity = new Vector3(playerrb.velocity.x, playerrb.velocity.y, 0);
			controller.playing = 'p';
		}
		
				
		
	}
	void OnTriggerStay (Collider collider){
		if (Input.GetKey("z")){
			itarget = 90;
			controller.playing = 'f';
		}
	}
}
