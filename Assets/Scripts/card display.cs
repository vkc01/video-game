using UnityEngine;
using cardsetup;
using Image = UnityEngine.UI.Image;

public class carddisplay : MonoBehaviour
{
    public Card cardData;

    void Start()
    {
        Image image = GetComponent<Image>();
        image.sprite = cardData.cardImage;
    }
}
