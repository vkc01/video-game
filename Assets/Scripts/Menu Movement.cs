using UnityEngine;
using UnityEngine.InputSystem;

public class MenuMovement : MonoBehaviour
{
    public Animator allelements;
    string wherePlayer = "title";
    public string whereSelector = "play";
    void OnEnter(InputValue value)
    {
        if (wherePlayer == "title")
        {
            Debug.Log("title screen movement");
            allelements.SetTrigger("titlescreentomainscreen");
            FindAnyObjectByType<menuselector>().titletomain();
            FindAnyObjectByType<menucamera>().titletomain();
        }
        if (wherePlayer == "main")
        {
            if (whereSelector == "play")
            {
                allelements.SetTrigger("mainscreentoplayscreen");
                FindAnyObjectByType<menuselector>().maintoplay();
                FindAnyObjectByType<menucamera>().maintoplay();
            }
            if (whereSelector == "credits")
            {
                allelements.SetTrigger("mainscreentocreditsscreen");
                FindAnyObjectByType<menuselector>().maintocredits();
                FindAnyObjectByType<menucamera>().maintocredits();
            }
            if (whereSelector == "help")
            {
                allelements.SetTrigger("mainscreentohelpscreen");
                FindAnyObjectByType<menuselector>().maintohelp();
                FindAnyObjectByType<menucamera>().maintohelp();
            }
            if (whereSelector == "title")
            {
                allelements.SetTrigger("mainscreentotitlescreen");
                FindAnyObjectByType<menuselector>().maintotitle();
                FindAnyObjectByType<menucamera>().maintotitle();
            }
        }
    }
    public void SelectorOnPlay()
    {
        whereSelector = "play";
    }
    public void SelectorOnHelp()
    {
        whereSelector = "help";
    }
    public void SelectorOnCredits()
    {
        whereSelector = "credits";
    }
    public void SelectorOnTitle()
    {
        whereSelector = "title";
    }
}
