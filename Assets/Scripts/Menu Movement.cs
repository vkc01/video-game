using UnityEngine;

public class MenuMovement : MonoBehaviour
{
    public Animator menuselection;
    string wherePlayer = "title";
    
    void OnEnter()
    {
        if (wherePlayer == "title")
        {
            FindAnyObjectByType<menuselector>().titletomain();
            FindAnyObjectByType<menucamera>().titletomain();
        }
    }
}
