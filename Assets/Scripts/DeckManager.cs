using UnityEngine;
using cardsetup;
using System.Collections.Generic;

public class DeckManager : MonoBehaviour
{
    public List<Card> allCards = new List<Card>();
    void Start()
    {
        Card[] cards = Resources.LoadAll<Card>("Cards");
        allCards.AddRange(cards);
    }

    public void DrawCard(handmanager handManager)
    {
        if (allCards.Count == 0)
        {
            return;
        }
        int randomIndex = Random.Range(0, allCards.Count);
        Card nextCard = allCards[randomIndex];
        handManager.AddCardToHand(nextCard);
    }
}