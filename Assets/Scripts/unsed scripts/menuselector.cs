using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class menuselector : MonoBehaviour
{
    public Animator selector;
    string whereselector = "play";
    string wherescreen = "title";
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
        if (movingselector == 0)
        {
            return;
        }
        if (wherescreen == "title")
        {
            if (whereselector == "play")
            {
                return;
            }
            if (whereselector == "help")
            {
                selector.SetTrigger("helptoplay");
                whereselector = "play";
            }
            if (whereselector == "credits")
            {
                selector.SetTrigger("creditstoplay");
                whereselector = "play";
            }
            if (whereselector == "title")
            {
                selector.SetTrigger("titletoplay");
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
                whereselector = "help";
            }
            if (whereselector == "credits")
            {
                selector.SetTrigger("creditstohelp");
                whereselector = "help";
            }
            if (whereselector == "title")
            {
                selector.SetTrigger("titletohelp");
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
                whereselector = "credits";
            }
            if (whereselector == "help")
            {
                selector.SetTrigger("helptocredits");
                whereselector = "credits";
            }
            if (whereselector == "title")
            {
                selector.SetTrigger("titletocredits");
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
                whereselector = "title";
            }
            if (whereselector == "help")
            {
                selector.SetTrigger("helptotitle");
                whereselector = "title";
            }
            if (whereselector == "credits")
            {
                selector.SetTrigger("creditstotitle");
                whereselector = "title";
            }
        }
    }
}