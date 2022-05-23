using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotation : MonoBehaviour
{
    public enum RotationMode
    {
        Local,
        Global,
    }

    public RotationMode mode = RotationMode.Local;
    public Vector3 axis = Vector3.up;
    public float angularVelocity = 100;

    void Update()
    {
        switch (mode)
        {
            case RotationMode.Local:
                transform.localRotation *= Quaternion.Euler(axis * angularVelocity * Time.deltaTime);
                break;
            case RotationMode.Global:
                transform.rotation *= Quaternion.Euler(axis * angularVelocity * Time.deltaTime);
                break;
        }
    }
}
