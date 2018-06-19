using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlanet : MonoBehaviour {

    public Transform target;


    void Update()
    {
        Vector3 relativePos = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(relativePos);
    }
}
