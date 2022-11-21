using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePosition : MonoBehaviour
{
    public bool IsPosition;
    
    void Update()
    {
        if (IsPosition)
        {
            transform.position = transform.position + new Vector3(0, 0, 2f) * Time.deltaTime;
        }
    }
}
