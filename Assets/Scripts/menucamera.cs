using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menucamera : MonoBehaviour
{
    [SerializeField] Camera cam;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = cam.transform.position + new Vector3(21.25f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = cam.transform.position + new Vector3(0, 10, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = cam.transform.position + new Vector3(-21.25f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = cam.transform.position + new Vector3(0, -10, 0);
        }
    }
}