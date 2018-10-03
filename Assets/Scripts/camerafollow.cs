using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour {
public Transform target;
private List<Vector3> oldcoordinates = new List<Vector3>();
public int stalllength;
	
	// Update is called once per frame
	void Update () {
		oldcoordinates.Add(new Vector3(target.position.x, Mathf.Max(target.position.y, 0), -10));
		if (oldcoordinates.Count > stalllength){
			transform.position = oldcoordinates[0];
			oldcoordinates.RemoveAt(0);
		}
	}
}
