using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScale : MonoBehaviour
{
    public bool IsScale;
    void Update()
    {
       if (IsScale)
        {
            transform.localScale = transform.localScale + new Vector3(1.5f, 1.5f, 1.5f) * Time.deltaTime;
        }
    }
}
