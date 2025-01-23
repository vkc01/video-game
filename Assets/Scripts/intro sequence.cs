using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class introsequence : MonoBehaviour
{
    public Animator blackScreen;
    public float transitionTime = 1f;
    public Image drape;
    Color drapecolor;

    void Start()
    {
        drapecolor = drape.color;
        drapecolor.a = 1;
        drape.color = drapecolor;
        blackScreen.SetTrigger(5);
        StartCoroutine(Wait3Seconds());
    }
    public IEnumerator Wait3Seconds()
    {
        yield return new WaitForSecondsRealtime(3);
        drapecolor.a = 0;
        drape.color = drapecolor;
    }    
}