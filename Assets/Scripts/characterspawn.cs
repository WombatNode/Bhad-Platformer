using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterspawn : MonoBehaviour {
public Vector3Int coordinates;
public Transform target;
	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag("MasterPlayer").GetComponentInParent<Transform>();
		target.position = coordinates;
	}

}
