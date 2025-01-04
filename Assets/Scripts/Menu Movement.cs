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
            wherePlayer = "main";
            movingselector = 1;
            selectorpos.anchoredPosition = new Vector2(-1.5f, 57);
        }
        if (wherePlayer == "main")
        {
            if (whereSelector == "play") // main to play screen
            {
                allelements.SetTrigger("mainscreentoplayscreen");
            }
            if (whereSelector == "credits") // main to credits screen
            {
                allelements.SetTrigger("mainscreentocreditsscreen");
            }
            if (whereSelector == "help") // main to help screen
            {
                allelements.SetTrigger("mainscreentohelpscreen");
            }
            if (whereSelector == "title") // main to title screen
            {
                allelements.SetTrigger("mainscreentotitlescreen");
                selector.SetTrigger("titletoplay");
                movingselector = 0;
                whereSelector = "play";
            }
        }
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
