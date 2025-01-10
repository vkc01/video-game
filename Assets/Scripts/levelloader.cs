using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelloader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public Image drape;
    Color drapecolor;

    public void GoToPlayfield(int value)
    {
        LoadNextLevel(value);
    }
    public void LoadNextLevel(int value)
    {
        StartCoroutine(LoadLevel(value));
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("CloseScreen");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}