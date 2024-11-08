using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class cardsattempt : MonoBehaviour
{
	public List<Image> items; // List that holds all my ten cards
    public Transform start;  //Location where to start adding my cards
    public Transform HandDeck; //The hand panel reference
    public float howManyAdded; // How many cards I added so far
    float gapFromOneItemToTheNextOne; //the gap I need between each card

    void Start()
    {
        howManyAdded = 0.0f;
        gapFromOneItemToTheNextOne = 1.0f;
    }

    public void FitCards()
    {
        Debug.Log("working");
        if (items.Count == 0) //if list is null, stop function
            return;

        Image img = items[0]; //Reference to first image in my list

        img.transform.position = start.position; // Relocating my card to the Start Position
        img.transform.position += new Vector3((howManyAdded * gapFromOneItemToTheNextOne), 0, 0); // Moving my card 1f to the right
        img.transform.SetParent(HandDeck); // Setting my card parent to be the Hand Panel

        items.RemoveAt(0);
        howManyAdded++;
    }
}