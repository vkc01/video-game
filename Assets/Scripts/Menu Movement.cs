using UnityEngine;
using UnityEngine.InputSystem;

public class MenuMovement : MonoBehaviour
{
    public Animator allelements;
    public Animator selector;
    public RectTransform selectorpos;
    string wherePlayer = "title";
    string whereSelector = "play";
    int movingselector = 0;
    void Start()
    {
        wherePlayer = "title";
        whereSelector = "play";
        movingselector = 0;
    }
    void OnEnter(InputValue value)
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
                MainToPlay();
                return;
            }
            if (whereSelector == "credits") // main to credits screen
            {
                allelements.SetTrigger("mainscreentocreditsscreen");
                selector.SetTrigger("selector-maintocredits");
                wherePlayer = "credits";
            }
            if (whereSelector == "help") // main to help screen
            {
                allelements.SetTrigger("mainscreentohelpscreen");
                selector.SetTrigger("selector-maintohelp");
                wherePlayer = "help";
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
        }
    }

    void MainToPlay()
    {
        selector.SetTrigger("selector-TPtoplayer2");
        whereSelector = "play";
    }

    // selector controller
    void OnOne(InputValue value)
    {
        /*Debug.Log(selectorpos.anchoredPosition);
        selectorpos.anchoredPosition = new Vector2(0, 0);
        Debug.Log(selectorpos.anchoredPosition);*/
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
    }
    void OnTwo(InputValue value)
    {
        Debug.Log("2");
        if (movingselector == 0)
        {
            Debug.Log("returned");
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
                Debug.Log("playtohelp");
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
    }
}
