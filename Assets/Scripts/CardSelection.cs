using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.UI;

public class Selection : MonoBehaviour
{
    public Animator SelectingCards;
    public Animator PlayerLabels;
    public Animator PlayerTurn;
    public TextMeshProUGUI cardDesc;
    int whereSelector;
    bool movableSelector;
    GameObject cardType;
    string cardData;
    int playerTurn;
    void Start()
    {
        playerTurn = 1;
        whereSelector = 1;
        SelectingCards.SetTrigger("startingposition");
        movableSelector = true;
    }
    void OnSpace(InputValue value)
    {
        if (!movableSelector)
        {
            return;
        }
        movableSelector = false;
        SelectingCards.SetTrigger("disappear");
        PlayerTurn.SetTrigger("player"+ playerTurn + "end");
        PlayerLabels.SetTrigger("player"+ playerTurn + "end");
        if (whereSelector == 1)
        {
            cardType = GameObject.Find("/Cards Canvas/Player " + playerTurn + "/Hand/Player " + playerTurn + " Card 1/Card Prefab(Clone)");
            cardData = cardType.GetComponent<carddisplay>().cardData.cardDesc;
            Debug.Log(cardData);
        }
        if (whereSelector == 2)
        {
            cardType = GameObject.Find("/Cards Canvas/Player " + playerTurn + "/Hand/Player " + playerTurn + " Card 2/Card Prefab(Clone)");
            cardData = cardType.GetComponent<carddisplay>().cardData.cardDesc;
            Debug.Log(cardData);
        }
        if (whereSelector == 3)
        {
            cardType = GameObject.Find("/Cards Canvas/Player " + playerTurn + "/Hand/Player " + playerTurn + " Card 3/Card Prefab(Clone)");
            cardData = cardType.GetComponent<carddisplay>().cardData.cardDesc;
            Debug.Log(cardData);
        }
        if (whereSelector == 4)
        {
            cardType = GameObject.Find("/Cards Canvas/Player " + playerTurn + "/Hand/Player " + playerTurn + " Card 4/Card Prefab(Clone)");
            cardData = cardType.GetComponent<carddisplay>().cardData.cardDesc;
            Debug.Log(cardData);
        }

        cardDesc.text = "Selected card is " + cardData + " type";
        StartCoroutine(ReappearInOne());
    }
    public IEnumerator ReappearInOne()
    {
        yield return new WaitForSecondsRealtime(1f);
        SelectingCards.SetTrigger("TPtoOne");
        whereSelector = 1;
        if (playerTurn == 4)
        {
            playerTurn = 0;
        }
        playerTurn++;
        movableSelector = true;
    }
    void OnOne(InputValue value)
    {
        if (whereSelector == 1 || !movableSelector)
        {
            return;
        }
        if (whereSelector == 2)
        {
            SelectingCards.SetTrigger("TwotoOne");
        }
        if (whereSelector == 3)
        {
            SelectingCards.SetTrigger("ThreetoOne");
        }
        if (whereSelector == 4)
        {
            SelectingCards.SetTrigger("FourtoOne");
        }
        whereSelector = 1;
    }
    void OnTwo(InputValue value)
    {
        if (whereSelector == 2 || !movableSelector)
        {
            return;
        }
        if (whereSelector == 1)
        {
            SelectingCards.SetTrigger("OnetoTwo");
        }
        if (whereSelector == 3)
        {
            SelectingCards.SetTrigger("ThreetoTwo");
        }
        if (whereSelector == 4)
        {
            SelectingCards.SetTrigger("FourtoTwo");
        }
        whereSelector = 2;
    }
    void OnThree(InputValue value)
    {
        if (whereSelector == 3 || !movableSelector)
        {
            return;
        }
        if (whereSelector == 1)
        {
            SelectingCards.SetTrigger("OnetoThree");
        }
        if (whereSelector == 2)
        {
            SelectingCards.SetTrigger("TwotoThree");
        }
        if (whereSelector == 4)
        {
            SelectingCards.SetTrigger("FourtoThree");
        }
        whereSelector = 3;
    }
    void OnFour(InputValue value)
    {
        if (whereSelector == 4 || !movableSelector)
        {
            return;
        }
        if (whereSelector == 1)
        {
            SelectingCards.SetTrigger("OnetoFour");
        }
        if (whereSelector == 2)
        {
            SelectingCards.SetTrigger("TwotoFour");
        }
        if (whereSelector == 3)
        {
            SelectingCards.SetTrigger("ThreetoFour");
        }
        whereSelector = 4;
    }
}