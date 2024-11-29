using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelloader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    // FindAnyObjectByType<CALLERSCRIPTSNAME>().GoToPlayfield();
    //GoToPlayfield()
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            LoadNextLevel();
            Debug.Log("next level");
        }
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("CloseScreen");
        yield return new WaitForSeconds(transitionTime);
        NextScene();
        SceneManager.LoadScene(levelIndex);
    }
    public void NextScene()
    {
        FindAnyObjectByType<nextscenescript>().GoToPlayfield();
    }
}