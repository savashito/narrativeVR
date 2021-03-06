﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class narrativeLightingManager : MonoBehaviour
{

    public GameObject light1;
    public GameObject light2;
    public GameObject light3;

    void Start()
    {
        light1.SetActive(false);
        light2.SetActive(false);
        light3.SetActive(false);
    }

    /*public void ActivateLigth(int index) {
        switch (index)
        {
            case 1:
                light1.SetActive(true);
                break;
            case 2:
                light2.SetActive(true);
                break;
            case 3:
                light3.SetActive(true);
                break;
            case 4:
                light4.SetActive(true);
                break;
        }
    }*/

    public void TurnOnFirstCornerLights()
    {
        light1.SetActive(true);
    }
    
    public void TurnOnSecondCornerLights()
    {
        light2.SetActive(true);
    }

    public void TurnOnThirdCornerLights()
    {
        light3.SetActive(true);
    }
}
