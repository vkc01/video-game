using UnityEngine;
using cardsetup;
using System.Collections.Generic;
using System;

public class handmanager : MonoBehaviour
{
    public DeckManager DeckManager;
    public GameObject cardPrefab;
    public Transform handTransform;
    public float whatPlayer;
    public float cardSpacing = -210f;
    public List<GameObject> cardsinHand = new List<GameObject>();

    void Update()
    {
        UpdateHandVisuals();
    }
    public void AddCardToHand(Card cardData)
    {
        GameObject newCard = Instantiate(cardPrefab, handTransform.position, Quaternion.identity, handTransform);
        cardsinHand.Add(newCard);
        newCard.GetComponent<carddisplay>().cardData = cardData;

        UpdateHandVisuals();
    }
    void UpdateHandVisuals()
    {
        int cardCount = cardsinHand.Count;
        if (cardCount == 1)
        {
            cardsinHand[0].transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            cardsinHand[0].transform.localPosition = new Vector3(0f, 0f, 0f);
            return;
        }
        
        for (int i = 0; i < cardCount; i++)
        {
            float horizontalOffset = cardSpacing * (i- (cardCount - 1) / 2);

            cardsinHand[i].transform.localPosition = new Vector3(horizontalOffset, 0f, 0f);
        }
    }
}