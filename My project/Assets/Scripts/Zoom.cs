using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public GameObject Model;

    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            transform.localPosition += Vector3.forward * Input.GetAxis("Mouse ScrollWheel") * 1;
            {
                RaycastHit hit;
                Ray ray = this.transform.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
                Vector3 desiredPosition;

                if (Physics.Raycast(ray, out hit))
                {
                    desiredPosition = hit.point;
                }
                else
                {
                    desiredPosition = transform.position;
                }
                float distance = Vector3.Distance(desiredPosition, transform.position);
                Vector3 direction = Vector3.Normalize(desiredPosition - transform.position) * (distance * Input.GetAxis("Mouse ScrollWheel"));

                transform.position += direction;
            }
        }
    }
}