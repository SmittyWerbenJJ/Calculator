using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "ColorPalette", menuName = "Calculator App/ColorPalette", order = 0)]
public class ColorPalette : ScriptableObject
{
    [Header("Global Colors")]
    public Color NormalColor;
    public Color HighlightedColor;
    public Color PressedColor;
    public Color SelectedColor;

}