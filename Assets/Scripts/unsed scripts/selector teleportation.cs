using System.Numerics;
using UnityEngine;

public class selectorteleportation : MonoBehaviour
{
    private RectTransform selectorpos;
    void Start()
    {
        selectorpos = GetComponent<RectTransform>();
    }
    public void maintoplay()
    {
        selectorpos.position = new UnityEngine.Vector3(-375, -160, 0);
        Debug.Log(selectorpos.position);
    }
}