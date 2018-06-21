using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {
	private Quaternion targetRotation;
	void Start () {
		SelectObjects.unit.Add(this.gameObject);
	}
	
	void Update () {
		
	}

	public void StartMove(Vector3 destination)
    {
        Debug.Log(destination);
		transform.rotation=Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(destination-transform.position),1*Time.deltaTime);
	}
}
