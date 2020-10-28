﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPickup : MonoBehaviour
{
    [SerializeField]
    int velGir = 2;
    
    public int valor = 1;

    // Start is called before the first frame update

    
    void Awake()
    {
        ScrControlGame.pickups++;
        ScrControlGame.pickupRestants++;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, velGir * Time.deltaTime);
      
    }
}
