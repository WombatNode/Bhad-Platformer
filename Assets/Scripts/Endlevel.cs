using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour {
 	public void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Player"){
			Debug.Log("Next Level");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
    }
}
