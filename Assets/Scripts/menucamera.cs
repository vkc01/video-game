using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menucamera : MonoBehaviour
{
    [SerializeField] public Animator MainCamera;
    string whereCam;
    void Start()
    {
        whereCam = "middle";
    }
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Debug.Log(whereCam);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (whereCam == "middle")
            {
                MainCamera.SetTrigger("moveright");
                whereCam = "right";
            }
            if (whereCam == "left")
            {
                MainCamera.SetTrigger("rightfromleft");
                whereCam = "middle";
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (whereCam == "middle")
            {
                MainCamera.SetTrigger("moveup");
                whereCam = "up";
            }
            if (whereCam == "down")
            {
                MainCamera.SetTrigger("upfromdown");
                whereCam = "middle";
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (whereCam == "middle")
            {
                MainCamera.SetTrigger("moveleft");
                whereCam = "left";
            }
            if (whereCam == "right")
            {
                MainCamera.SetTrigger("leftfromright");
                whereCam = "middle";
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (whereCam == "middle")
            {
                MainCamera.SetTrigger("movedown");
                whereCam = "down";
            }
            if (whereCam == "up")
            {
                MainCamera.SetTrigger("downfromup");
                whereCam = "middle";
            }
        }
    }
}