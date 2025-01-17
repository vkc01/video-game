using System.Collections.Generic;
using UnityEngine;

namespace cardsetup
{
    [CreateAssetMenu(fileName = "Card", menuName = "Scriptable Objects/Card")]
    public class Card : ScriptableObject
    {
        public string cardName;
        public List<CardType> cardType;
        public Sprite cardImage;
        public enum CardType
        {
            DMG,
            Support,
            Blind,
            Poison,
            Multiplier,
            Bonus,
        }
    }
}
