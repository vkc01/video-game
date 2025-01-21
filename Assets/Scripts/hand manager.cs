using UnityEngine;
using cardsetup;
using System.Collections.Generic;
using System;
using System.Security.Cryptography;

public class handmanager : MonoBehaviour
{
    public DeckManager DeckManager;
    public GameObject cardPrefab;
    public Transform hand;
    public int playerId;
    public float cardCounter = 1;
    public List<GameObject> cardsinHand = new List<GameObject>();

    void Start()
    {
        Invoke("StartGame", 1f);
    }
    void StartGame()
    {
        DeckManager.DrawCard(this);
        cardCounter++;
        DeckManager.DrawCard(this);
        cardCounter++;
        DeckManager.DrawCard(this);
        cardCounter++;
        DeckManager.DrawCard(this);
    }
    public void AddCardToHand(Card cardData)
    {
        GameObject newCard = Instantiate(cardPrefab, GameObject.Find("Player " + playerId + " Card " + cardCounter).transform.position, Quaternion.identity, GameObject.Find("Player " + playerId + " Card " + cardCounter).transform);
        cardsinHand.Add(newCard);
        newCard.GetComponent<carddisplay>().cardData = cardData;
    }
}