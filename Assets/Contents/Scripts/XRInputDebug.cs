using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR;

[ExecuteAlways]
public class XRInputDebug : MonoBehaviour
{
    void PrintDevices() 
    {
        // https://docs.unity3d.com/Manual/xr_input.html
        var devices = new List<InputDevice>();
        InputDevices.GetDevices(devices);
        GetComponent<TMPro.TextMeshProUGUI>().text = "devices:\n" + 
            string.Join("\n", devices.Select(d => $"device: {d.name} role: {d.characteristics}"));
    }

    void Start()
    {
        PrintDevices();
    }
}
