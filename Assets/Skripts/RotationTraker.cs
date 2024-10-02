using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTraker : MonoBehaviour
{
    public Camera cam;
    Vector3 MPosition;
    

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 WMPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 diff = WMPosition - transform.position;
        float rotateY = Mathf.Atan2(diff.z, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, -rotateY+ 90f, 0f);
        
    }
}
