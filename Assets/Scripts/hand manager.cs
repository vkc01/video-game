using UnityEngine;
using cardsetup;
using System.Collections.Generic;
using System;

public class handmanager : MonoBehaviour
{
    public GameObject cardPrefab;
    public Transform handTransform;
    public float fanSpread = 5;
    public List<GameObject> cardsinHand = new List<GameObject>();
    void Start()
    {
        AddCardToHand();
        AddCardToHand();
        AddCardToHand();
        AddCardToHand();
    }

    public void AddCardToHand()
    {
        GameObject newcard = Instantiate(cardPrefab, handTransform.position, Quaternion.identity, handTransform);
        cardsinHand.Add(newcard);
    }
    void UpdateHandVisuals()
    {
        int cardCount = cardsinHand.Count;
        for (int i = 0; i < cardCount; i++)
        {
            float rotationAngle = fanSpread * (i - (cardCount - 1) / 2);
            cardsinHand[i].transform.localRotation = Quaternion.Euler(0f, 0f, rotationAngle);
        }
    }
}
