using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUnitStrategy : MonoBehaviour {

    private Quaternion targetRotation;
    private Camera camera;

    void Start()
    {
        camera = GetComponent<Camera>();
    }

    void rayGround()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                float x = hit.transform.position.x;
                float y = hit.transform.position.y;
                float z = hit.transform.position.z;

                Vector3 destination = new Vector3(x, y, z);
                StartMove(destination);
            }
        }
    }

    public void StartMove(Vector3 destination)
    {
        targetRotation = Quaternion.LookRotation(destination - transform.position);
    }
}
