using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRotation : MonoBehaviour
{
    public bool IsRotation;
    void Update()
    {
        if (IsRotation)
        {
           transform.rotation = transform.rotation * Quaternion.Euler(new Vector3(-5, 0, 0) * Time.deltaTime);
        }
    }
}
