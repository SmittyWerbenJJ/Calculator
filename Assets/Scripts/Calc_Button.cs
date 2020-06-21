using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Calculator;
using System;


[ExecuteInEditMode]
[RequireComponent(typeof(Button))]
public class Calc_Button : MonoBehaviour
{
    [Header("Button Display")]
    public eNumpad_buttons NumpadButton;
    public string value;

    private TMPro.TextMeshProUGUI _textComponent;
    private Button _button;




    private void Awake()
    {
        _button = GetComponent<Button>();
        _textComponent = GetComponentInChildren<TMPro.TextMeshProUGUI>();

        setGameobjectName();
        setText(value);

    }

    #region Methods
    ///<summary>Set the Text of the Button (TextmeshProGUI-Component)</summary>
    public void setText(string newText)
    {
        _textComponent.text = newText;
    }

    ///<summary>Sets the Button Color(Normal,Highlight,Pressed)</summary>
    public void setButtonColor(ColorPalette colorPalette)
    {
        if (!_button) Debug.Log($"No button for: {gameObject.name}");
        var colorBlock = _button.colors;

        colorBlock.normalColor = colorPalette.NormalColor;
        colorBlock.highlightedColor = colorPalette.HighlightedColor;
        colorBlock.pressedColor = colorPalette.PressedColor;
        colorBlock.selectedColor = colorPalette.SelectedColor;

        _button.colors = colorBlock;

    }

    ///<summary>Sets the Gameobject Name depending on its Functionality and Value</summary>
    public void setGameobjectName()
    {
        string name = "Button (";
        //GameObjectNaming
        if (NumpadButton == eNumpad_buttons.Numbers)
        {
            name += value;
        }
        else
        {
            name += NumpadButton.ToString();
        }
        name += ")";
        gameObject.transform.name = name;
    }
    #endregion

}
