using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spritehurt : MonoBehaviour
{
    [SerializeField] Image myImage;
    [SerializeField] Color myColor;
    void Start()
    {
        myColor.a = 1;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            ColorToDamage();
        }
    }

    /*  place this in update in the caller script: FindAnyObjectByType<CALLERSCRIPTSNAME>().ColorToDamage(); */
    void ColorToDamage()
    {
        myImage.color = myColor;
    }

}
