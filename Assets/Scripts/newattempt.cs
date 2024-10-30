using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelloader : MonoBehaviour
{
    public static SceneController instance;
    Animator transitionAnim;
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            StartCoroutine(LoadNextLevel());
        }
    }
    IEnumerator LoadLevel()
    {
        transitionAnim.SetTrigger("Start");
        yield return new WaitforSeconds(1);
        SceneManager.LoadSceneAync(SceneManager.GetActiveScene().buildIndex + 1);
    }
}