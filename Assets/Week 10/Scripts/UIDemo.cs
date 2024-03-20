using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIDemo : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public SpriteRenderer sr;
    public Color Start;
    public Color End;
    float interpolation;
    public void SliderValueHasChanged(Single value)
    {
        interpolation = value;

    }

    private void Update()
    {
        sr.color = Color.Lerp(Start, End, (interpolation/60));
    }

    public void DropDownSelectionHasChanged(Int32 value)
    {
        Debug.Log(dropdown.options[value].text);
    }
}
