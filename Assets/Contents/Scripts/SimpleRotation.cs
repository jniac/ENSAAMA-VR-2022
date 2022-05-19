using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotation : MonoBehaviour
{
    public float angularVelocity = 100;

    void Update()
    {
        transform.localRotation *= Quaternion.Euler(0, angularVelocity * Time.deltaTime, 0);    
    }
}
