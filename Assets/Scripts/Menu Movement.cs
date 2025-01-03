using UnityEngine;

public class MenuMovement : MonoBehaviour
{
    public Animator allelements;
    string wherePlayer = "title";
    public string whereSelector = "play";
    void OnEnter()
    {
        if (wherePlayer == "title")
        {
            allelements.SetTrigger("helptoplay");
            FindAnyObjectByType<menuselector>().titletomain();
            FindAnyObjectByType<menucamera>().titletomain();
        }
        if (wherePlayer == "main")
        {
            if (whereSelector == "play")
            {
                FindAnyObjectByType<menuselector>().maintoplay();
                FindAnyObjectByType<menucamera>().maintoplay();
            }
            if (whereSelector == "credits")
            {
                FindAnyObjectByType<menuselector>().maintocredits();
                FindAnyObjectByType<menucamera>().maintocredits();
            }
            if (whereSelector == "help")
            {
                FindAnyObjectByType<menuselector>().maintohelp();
                FindAnyObjectByType<menucamera>().maintohelp();
            }
            if (whereSelector == "title")
            {
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
