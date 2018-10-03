using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "KillPlayer")
		{
			Destroy(this.gameObject);
			gameOver ();
		}
	}

	void gameOver (){
		//Restarts the Scene
		SceneManager.LoadScene( SceneManager.GetActiveScene().name );
	}
}
