using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Selection : MonoBehaviour
{
    float CardSelected = 0;
    float CardSelection = 0;

    void Update()
    {
        Keyboard();
    }
    void Keyboard()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            CardSelected = CardSelection + 1;
        }
    }
}