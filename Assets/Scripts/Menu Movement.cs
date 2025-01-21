using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Numerics;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuMovement : MonoBehaviour
{
    public Animator allelements;
    public Animator selector;
    string wherePlayer = "title";
    string whereSelector = "play";
    int movingselector = 0;
    void Start()
    {
        wherePlayer = "title";
        whereSelector = "play";
        movingselector = 0;
    }
    void OnSpace(InputValue value)
    {
        if (wherePlayer == "title") // goes from title to main
        {
            allelements.SetTrigger("titlescreentomainscreen");
            selector.SetTrigger("selector-titletomain");
            wherePlayer = "main";
            movingselector = 1;
            return;
        }
        if (wherePlayer == "main")
        {
            if (whereSelector == "play") // main to play screen
            {
                allelements.SetTrigger("mainscreentoplayscreen");
                selector.SetTrigger("selector-maintoplay");
                wherePlayer = "play";
                StartCoroutine(MainToPlay());
                return;
            }
            if (whereSelector == "credits") // main to credits screen
            {
                allelements.SetTrigger("mainscreentocreditsscreen");
                selector.SetTrigger("selector-maintocredits");
                wherePlayer = "credits";
            }
            if (whereSelector == "title") // main to title screen
            {
                allelements.SetTrigger("mainscreentotitlescreen");
                selector.SetTrigger("selector-maintotitle");
                wherePlayer = "title";
                movingselector = 0;
                whereSelector = "play";
                return;
            }
            if (whereSelector == "help") // main to help screen
            {
                allelements.SetTrigger("mainscreentohelpscreen");
                selector.SetTrigger("selector-maintohelp");
                wherePlayer = "help";
                StartCoroutine(MainToHelp());
                return;
            }
        }
        if (wherePlayer == "play")
        {
            if (whereSelector == "main") // play to main screen
            {
                allelements.SetTrigger("playscreentomainscreen");
                selector.SetTrigger("selector-playtomain");
                wherePlayer = "main";
                StartCoroutine(ToMain());
                return;
            }
            if (whereSelector == "2players") // selects 2 players
            {
                Debug.Log("2 players selected");
                FindAnyObjectByType<levelloader>().GoToPlayfield(1);
            }
            if (whereSelector == "3players") // selects 3 players
            {
                Debug.Log("3 players selected");
                FindAnyObjectByType<levelloader>().GoToPlayfield(1);
            }
            if (whereSelector == "4players") // selects 4 players
            {
                Debug.Log("4 players selected");
                FindAnyObjectByType<levelloader>().GoToPlayfield(1);
            }
        }
        if (wherePlayer == "credits")
        {
            if (whereSelector == "main") // credits to main screen
            {
                allelements.SetTrigger("creditsscreentomainscreen");
                selector.SetTrigger("selector-creditstomain");
                wherePlayer = "main";
                StartCoroutine(ToMain());
                return;
            }
        }
        if (wherePlayer == "help")
        {
            if (whereSelector == "main") // help to main screen
            {
                allelements.SetTrigger("helpscreentomainscreen");
                selector.SetTrigger("selector-helptomain");
                wherePlayer = "main";
                StartCoroutine(ToMain());
                return;
            }
        }
    }

    public IEnumerator MainToPlay()
    {
        yield return new WaitForSecondsRealtime(1f);
        selector.SetTrigger("selector-TPtoplaymainbutton");
        whereSelector = "main";
    }
    public IEnumerator ToMain()
    {
        yield return new WaitForSecondsRealtime(0.96f);
        selector.SetTrigger("selector-TPtoplaybutton");
        whereSelector = "play";
    }
    public IEnumerator MainToHelp()
    {
        yield return new WaitForSecondsRealtime(1f);
        selector.SetTrigger("selector-TPtohelpmainbutton");
        whereSelector = "main";
    }
    
    // selector controller
    void OnOne(InputValue value)
    {
        if (movingselector == 0)
        {
            return;
        }
        if (wherePlayer == "main")
        {
            if (whereSelector == "play")
            {
                return;
            }
            if (whereSelector == "help")
            {
                selector.SetTrigger("helptoplay");
                whereSelector = "play";
            }
            if (whereSelector == "credits")
            {
                selector.SetTrigger("creditstoplay");
                whereSelector = "play";
            }
            if (whereSelector == "title")
            {
                selector.SetTrigger("titletoplay");
                whereSelector = "play";
            }
        }
        if (wherePlayer == "play")
        {
            if (whereSelector == "main")
            {
                return;
            }
            if (whereSelector == "2players")
            {
                selector.SetTrigger("2playerstomain");
                whereSelector = "main";
            }
            if (whereSelector == "3players")
            {
                selector.SetTrigger("3playerstomain");
                whereSelector = "main";
            }
            if (whereSelector == "4players")
            {
                selector.SetTrigger("4playerstomain");
                whereSelector = "main";
            }
        }
    }
    void OnTwo(InputValue value)
    {
        if (movingselector == 0)
        {
            return;
        }
        if (wherePlayer == "main")
        {
            if (whereSelector == "help")
            {
                return;
            }
            if (whereSelector == "play")
            {
                selector.SetTrigger("playtohelp");
                whereSelector = "help";
            }
            if (whereSelector == "credits")
            {
                selector.SetTrigger("creditstohelp");
                whereSelector = "help";
            }
            if (whereSelector == "title")
            {
                selector.SetTrigger("titletohelp");
                whereSelector = "help";
            }
        }
        if (wherePlayer == "play")
        {
            if (whereSelector == "2players")
            {
                return;
            }
            if (whereSelector == "main")
            {
                selector.SetTrigger("mainto2players");
                whereSelector = "2players";
            }
            if (whereSelector == "3players")
            {
                selector.SetTrigger("3playersto2players");
                whereSelector = "2players";
            }
            if (whereSelector == "4players")
            {
                selector.SetTrigger("4playersto2players");
                whereSelector = "2players";
            }
        }
    }
    void OnThree(InputValue value)
    {
        if (movingselector == 0)
        {
            return;
        }
        if (wherePlayer == "main")
        {
            if (whereSelector == "credits")
            {
                return;
            }
            if (whereSelector == "play")
            {
                selector.SetTrigger("playtocredits");
                whereSelector = "credits";
            }
            if (whereSelector == "help")
            {
                selector.SetTrigger("helptocredits");
                whereSelector = "credits";
            }
            if (whereSelector == "title")
            {
                selector.SetTrigger("titletocredits");
                whereSelector = "credits";
            }
        }
        if (wherePlayer == "play")
        {
            if (whereSelector == "3players")
            {
                return;
            }
            if (whereSelector == "2players")
            {
                selector.SetTrigger("2playersto3players");
                whereSelector = "3players";
            }
            if (whereSelector == "main")
            {
                selector.SetTrigger("mainto3players");
                whereSelector = "3players";
            }
            if (whereSelector == "4players")
            {
                selector.SetTrigger("4playersto3players");
                whereSelector = "3players";
            }
        }
    }
    void OnFour(InputValue value)
    {
        if (movingselector == 0)
        {
            return;
        }
        if (wherePlayer == "main")
        {
            if (whereSelector == "title")
            {
                return;
            }
            if (whereSelector == "play")
            {
                selector.SetTrigger("playtotitle");
                whereSelector = "title";
            }
            if (whereSelector == "help")
            {
                selector.SetTrigger("helptotitle");
                whereSelector = "title";
            }
            if (whereSelector == "credits")
            {
                selector.SetTrigger("creditstotitle");
                whereSelector = "title";
            }
        }
        if (wherePlayer == "play")
        {
            if (whereSelector == "4players")
            {
                return;
            }
            if (whereSelector == "2players")
            {
                selector.SetTrigger("2playersto4players");
                whereSelector = "4players";
            }
            if (whereSelector == "3players")
            {
                selector.SetTrigger("3playersto4players");
                whereSelector = "4players";
            }
            if (whereSelector == "main")
            {
                selector.SetTrigger("mainto4players");
                whereSelector = "4players";
            }
        }
    }
}