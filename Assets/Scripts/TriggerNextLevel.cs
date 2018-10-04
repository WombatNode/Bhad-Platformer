
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerNextLevel : MonoBehaviour {

	public void LoadNextLevel(){
		Debug.Log("super duper gay");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
