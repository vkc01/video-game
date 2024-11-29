using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscenescript : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    public void GoToPlayfield()
    {
        Invoke("NextScene", transitionTime);
    }

    void NextScene()
    {
        transition.SetTrigger("CloseScreen");
    }
}