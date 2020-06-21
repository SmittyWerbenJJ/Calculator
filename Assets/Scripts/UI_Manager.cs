using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [Header("Scene Elements")]
    [SerializeField] public calc_Input_Panel CalculatorInputPanel;

    [Header("Numpad Sliding")]
    public float slidingTime;

    [Header("Colors - Scriptable")]
    public ColorPalette colorPalette;

    private Calc_Button[] _Buttons;
    private bool _numpad_visible = true;

    private void Start()
    {
        // Find all buttons in Scene
        _Buttons = FindObjectsOfType<Calc_Button>();

        // Set Colorpalette for the Numpad Buttons.
        foreach (var btn in _Buttons)
        {
            if (!btn)
            {
                Debug.LogWarning($"No Button for {gameObject.name}");
                return;
            }
            btn.setButtonColor(colorPalette);
        }
    }

    ///<summary> Show/Hide the Numpad whe the Slider has been clicked</summary>
    public void slider_clicked()
    {
        var rectTransform = CalculatorInputPanel.GetComponent<RectTransform>();
        var numpadHeight = CalculatorInputPanel.numpad.GetComponent<RectTransform>().rect.height;

        float destination;

        if (_numpad_visible)
        {
            destination = -numpadHeight;
        }
        else
        {
            destination = 0;
        }
        _numpad_visible = !_numpad_visible;
        LeanTween.moveY(rectTransform, destination, slidingTime);
    }


}