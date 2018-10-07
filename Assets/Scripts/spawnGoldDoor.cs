using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnGoldDoor : MonoBehaviour {
public GameObject target;
//coordinates is a list of where it will be copied to. I would try to keep all the z's at 0
public Vector3[] coordinates;
public bool[] side;
private int itarget;
	void Start () {
		for (int copy = 0; copy < coordinates.Length; copy ++){
			if (side[copy]){
				itarget = 0;
			}else{
				itarget = 180;
			}
			target.GetComponentInChildren<ControlGoldDoor>().i = itarget;
			target.GetComponentInChildren<ControlGoldDoor>().itarget = itarget;
			Instantiate(target, coordinates[copy], target.transform.rotation);
		}
		Destroy(target);
	}
}

