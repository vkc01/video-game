using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;

public class Selection : MonoBehaviour
{
    public Animator SelectingCards;
    int whereSelector;
    void Start()
    {
        whereSelector = 1;
    }
    void OnSpace(InputValue value)
    {
        
    }
    public IEnumerator MainToPlay()
    {
        yield return new WaitForSecondsRealtime(1f);
        SelectingCards.SetTrigger("TPtoOne");
        whereSelector = 1;
    }
    void OnOne(InputValue value)
    {
        Debug.Log("One Pressed");
        if (whereSelector == 1)
        {
            return;
        }
        if (whereSelector == 2)
        {
            SelectingCards.SetTrigger("OnetoTwo");
            whereSelector = 2;
            Debug.Log("OnetoTwo");
        }
        if (whereSelector == 3)
        {
            SelectingCards.SetTrigger("OnetoThree");
        }
        if (whereSelector == 4)
        {
            SelectingCards.SetTrigger("OnetoFour");
        }
    }
    void OnTwo(InputValue value)
    {
        if (whereSelector == 2)
        {
            return;
        }
        if (whereSelector == 1)
        {
            SelectingCards.SetTrigger("TwotoOne");
        }
        if (whereSelector == 3)
        {
            SelectingCards.SetTrigger("TwotoThree");
        }
        if (whereSelector == 4)
        {
            SelectingCards.SetTrigger("TwotoFour");
        }
    }
    void OnThree(InputValue value)
    {
        if (whereSelector == 3)
        {
            return;
        }
        if (whereSelector == 1)
        {
            SelectingCards.SetTrigger("ThreetoOne");
        }
        if (whereSelector == 2)
        {
            SelectingCards.SetTrigger("ThreetoTwo");
        }
        if (whereSelector == 4)
        {
            SelectingCards.SetTrigger("ThreetoFour");
        }
    }
    void OnFour(InputValue value)
    {
        if (whereSelector == 4)
        {
            return;
        }
        if (whereSelector == 1)
        {
            SelectingCards.SetTrigger("FourtoOne");
        }
        if (whereSelector == 2)
        {
            SelectingCards.SetTrigger("FourtoTwo");
        }
        if (whereSelector == 3)
        {
            SelectingCards.SetTrigger("FourtoThree");
        }
    }
}