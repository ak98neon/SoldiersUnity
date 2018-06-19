using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSun : MonoBehaviour {

    public float speed = 5f;

    private float periodSun = 10f;

    void Update()
    {
        transform.Rotate(Vector3.up);
        //transform.Translate(-1 * speed * Time.deltaTime, 0, 0);
    }
}
