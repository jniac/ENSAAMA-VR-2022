using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class CustomColorOnAllMaterials : MonoBehaviour
{
    public Color customColor = Color.cyan;
    public string colorMaterialName = "_BaseColor";

    Dictionary<Material, Color> initialColors = new Dictionary<Material, Color>();

    public void EnterCustomColor()
    {
        var materials = GetComponentsInChildren<MeshRenderer>()
            .SelectMany(mr => mr.materials)
            .ToArray();  

        foreach (var material in materials)
        {
            initialColors.Add(material, material.GetColor(colorMaterialName));
            material.SetColor(colorMaterialName, customColor);
        }  
    }

    public void ExitCustomColor()
    {
        foreach(var entry in initialColors)
        {
            var material = entry.Key;
            var color = entry.Value;
            material.SetColor(colorMaterialName, color);
        }

        initialColors.Clear();
    }
}
