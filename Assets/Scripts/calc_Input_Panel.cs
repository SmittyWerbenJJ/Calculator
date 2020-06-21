using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calc_Input_Panel : MonoBehaviour
{
    public Calc_Numpad numpad;
    public Calc_slider slider;


    // Start is called before the first frame update
    void Start()
    {
        if (!numpad) Debug.LogWarning("No Numpad found for " + gameObject.name);
        if (!slider) Debug.LogWarning("No slider found for " + gameObject.name);
    }
}
