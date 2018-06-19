using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSun : MonoBehaviour {

    public float speed = 0.1f;

    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, speed * Time.deltaTime);
    }
}
