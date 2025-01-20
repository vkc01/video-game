using UnityEngine;
using cardsetup;

public class GameController : MonoBehaviour
{
    public DeckManager deckManager;
    public handmanager handManager;

    void Start()
    {
        DrawRandomCardForPlayer(1);
        DrawRandomCardForPlayer(2);
    }

    public void DrawRandomCardForPlayer(int playerId)
    {
        //Card randomCard = deckManager.PullRandomCard();
        //if (randomCard != null)
        //{
        //    handManager.AddCardToHand(playerId, randomCard);
        //}
    }
}