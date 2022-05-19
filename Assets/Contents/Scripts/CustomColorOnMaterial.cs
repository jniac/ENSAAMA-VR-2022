using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomColorOnMaterial : MonoBehaviour
{
    public string colorName = "_BaseColor";
    public Color customColor = Color.cyan;
    Color initialColor;

    void Start()
    {
        initialColor = GetComponent<MeshRenderer>().material.GetColor(colorName);
    }

    public void EnterCustomColor()
    {
        GetComponent<MeshRenderer>().material.SetColor(colorName, customColor);
    }

    public void ExitCustomColor()
    {
        GetComponent<MeshRenderer>().material.SetColor(colorName, initialColor);
    }
}
