using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calc_Numpad : MonoBehaviour
{
    public Calc_Button[] keys;


    void Start()
    {
        keys = GetComponentsInChildren<Calc_Button>();

    }


}
