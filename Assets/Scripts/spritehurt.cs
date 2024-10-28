using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Image myImage;
    [SerializeField] Color myColor;
    void Start()
    {
        myColor.a = 1;
    }

    /*  place this in update in the caller script: FindAnyObjectByType<CALLERSCRIPTSNAME>().ColorToDamage(); */
    void ColorToDamage()
    {
        myImage.color = myColor;
    }

}
