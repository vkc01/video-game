using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newattempt : MonoBehaviour
{
    [SerializeField] Animator transitionAnim;
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            StartCoroutine(LoadLevel());
        }
    }
    IEnumerator LoadLevel()
    {
        transitionAnim.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}