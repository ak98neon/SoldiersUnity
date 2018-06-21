using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUnitStrategy : MonoBehaviour {
     private Camera camera;
    void Start()
    {
        camera = GetComponent<Camera>();
    }

    void Update() {
        rayGround();
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

                Vector3 lol = Input.mousePosition;
                Vector3 destination = new Vector3(x, y, z);

                foreach (GameObject un in SelectObjects.unitSelected) {
                    un.GetComponent<Unit>().StartMove(lol);
                }
            }
        }
    }
}
