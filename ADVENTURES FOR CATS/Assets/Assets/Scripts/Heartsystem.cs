﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heartsystem : MonoBehaviour
{
    public static int health;
    public GameObject Heart1, Heart2, Heart3, Heart4;
    void Start()
    {
        Heart1.SetActive(true);
        Heart2.SetActive(true);
        Heart3.SetActive(true);
        Heart4.SetActive(true);
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        switch(health)
        {
            case 5:
                Heart1.SetActive(true);
                Heart2.SetActive(true);
                Heart3.SetActive(true);
                break;

            case 4:
                Heart1.SetActive(true);
                Heart2.SetActive(true);
                Heart3.SetActive(true);
                break;

            case 3:
                Heart1.SetActive(true);
                Heart2.SetActive(true);
                Heart3.SetActive(true);
                break;

            case 2:
                Heart1.SetActive(true);
                Heart2.SetActive(true);
                Heart3.SetActive(false);
                break;

            case 1:
                Heart1.SetActive(true);
                Heart2.SetActive(false);
                Heart3.SetActive(false);
                break;

            case 0:
                Heart1.SetActive(false);
                Heart2.SetActive(false);
                Heart3.SetActive(false);
                break;
        }


            
    }

}

