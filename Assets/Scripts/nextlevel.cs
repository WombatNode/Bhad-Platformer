using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextlevel : MonoBehaviour {
public GameObject completelevelui;
	// Use this for initialization
	public void Start(){
		completelevelui.SetActive(false);
	}
	public void NextLevel(){
		Debug.Log("You are proceeding to the next level");
		completelevelui.SetActive(true);
	}
}
