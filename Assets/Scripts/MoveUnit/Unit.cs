using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

	public bool isMove = false;
	public Vector3 destination;
	private Quaternion targetRotation;
	void Start () {
		SelectObjects.unit.Add(this.gameObject);
	}
	
	void Update () {
		StartMove();
	}

	public void StartMove()
    {
		if (isMove) {
			if (Vector3.Distance(destination, transform.position) > 0.5f) {
				transform.position = Vector3.MoveTowards(transform.position, destination, 5f * Time.deltaTime);
			} else {
				isMove = false;
			}
		}
	}
}
