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

            if (Physics.Raycast(ray, out hit))
            {
                Vector3 targetPosition = hit.point;

                if (SelectObjects.unitSelected.Count > 0) {
                    foreach (GameObject un in SelectObjects.unitSelected) {
                        un.GetComponent<Unit>().destination = targetPosition;
                        un.GetComponent<Unit>().isMove = true;
                    }
                }
            }
        }
    }
}
