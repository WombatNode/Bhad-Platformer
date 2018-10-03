using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {
public GameObject target;
//coordinates is a list of where it will be copied to. I would try to keep all the z's at 0
public Vector3[] coordinates;
	void Start () {
		for (int copy = 0; copy < coordinates.Length; copy ++){
			Instantiate(target, coordinates[copy], target.transform.rotation);
		}
		Destroy(target);
	}
}

