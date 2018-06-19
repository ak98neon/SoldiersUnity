using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlanet : MonoBehaviour {

    private Transform planet;
    public float moveRotation = 1f;

	void Start () {
        planet = GetComponent<Transform>();
	}
	
	void Update () {
        planet.Rotate(Vector3.up * moveRotation * Time.deltaTime);
	}
}
