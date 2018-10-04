using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour {
	public GeneralController controller;
	public void Start(){
		controller = GameObject.Find("Initialiser").GetComponent<GeneralController>();
	}
 	public void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Player"){
			Debug.Log("Next Level");
			controller.playing = 'p';
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
    }
}
