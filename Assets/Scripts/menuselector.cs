using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class menuselector : MonoBehaviour
{
    public Animator selector;
    string whereselector = "play";
    float movingselector = 0;
    public void titletomain()
    {
        movingselector = 1;
    }
    public void maintotitle()
    {
        movingselector = 0;
        whereselector = "play";
    }
    public void maintoplay()
    {
        // set whereselector to whatever it should be
        whereselector = "XXXXXXX";
    }
    public void maintohelp()
    {
        // set whereselector to whatever it should be
        whereselector = "XXXXXXX";
    }
    public void maintocredits()
    {
        // set whereselector to whatever it should be
        whereselector = "XXXXXXX";
    }
    void OnOne(InputValue value)
    {
        if (value.isPressed && movingselector == 1)
        {
            if (whereselector == "play")
            {
                return;
            }
            if (whereselector == "help")
            {
                selector.SetTrigger("helptoplay");
                FindAnyObjectByType<MenuMovement>().SelectorOnPlay();
                whereselector = "play";
            }
            if (whereselector == "credits")
            {
                selector.SetTrigger("creditstoplay");
                FindAnyObjectByType<MenuMovement>().SelectorOnPlay();
                whereselector = "play";
            }
            if (whereselector == "title")
            {
                selector.SetTrigger("titletoplay");
                FindAnyObjectByType<MenuMovement>().SelectorOnPlay();
                whereselector = "play";
            }
        }
    }
    void OnTwo(InputValue value)
    {
        if (value.isPressed && movingselector == 1)
        {
            if (whereselector == "help")
            {
                return;
            }
            if (whereselector == "play")
            {
                selector.SetTrigger("playtohelp");
                FindAnyObjectByType<MenuMovement>().SelectorOnHelp();
                whereselector = "help";
            }
            if (whereselector == "credits")
            {
                selector.SetTrigger("creditstohelp");
                FindAnyObjectByType<MenuMovement>().SelectorOnHelp();
                whereselector = "help";
            }
            if (whereselector == "title")
            {
                selector.SetTrigger("titletohelp");
                FindAnyObjectByType<MenuMovement>().SelectorOnHelp();
                whereselector = "help";
            }
        }
    }
    void OnThree(InputValue value)
    {
        if (value.isPressed && movingselector == 1)
        {
            if (whereselector == "credits")
            {
                return;
            }
            if (whereselector == "play")
            {
                selector.SetTrigger("playtocredits");
                FindAnyObjectByType<MenuMovement>().SelectorOnCredits();
                whereselector = "credits";
            }
            if (whereselector == "help")
            {
                selector.SetTrigger("helptocredits");
                FindAnyObjectByType<MenuMovement>().SelectorOnCredits();
                whereselector = "credits";
            }
            if (whereselector == "title")
            {
                selector.SetTrigger("titletocredits");
                FindAnyObjectByType<MenuMovement>().SelectorOnCredits();
                whereselector = "credits";
            }
        }
    }
    void OnFour(InputValue value)
    {
        if (value.isPressed && movingselector == 1)
        {
            if (whereselector == "title")
            {
                return;
            }
            if (whereselector == "play")
            {
                selector.SetTrigger("playtotitle");
                FindAnyObjectByType<MenuMovement>().SelectorOnTitle();
                whereselector = "title";
            }
            if (whereselector == "help")
            {
                selector.SetTrigger("helptotitle");
                FindAnyObjectByType<MenuMovement>().SelectorOnTitle();
                whereselector = "title";
            }
            if (whereselector == "credits")
            {
                selector.SetTrigger("creditstotitle");
                FindAnyObjectByType<MenuMovement>().SelectorOnTitle();
                whereselector = "title";
            }
        }
    }
}