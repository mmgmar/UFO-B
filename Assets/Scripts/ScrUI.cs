using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// ----------------------------------------------------------------------------------
/// DESCRIPCIÓ
///         Script utilitzat per ...
/// AUTOR:  ...
/// DATA:   ...
/// VERSIÓ: 1.0
/// CONTROL DE VERSIONS
///         1.0: primera versió. ...
/// ----------------------------------------------------------------------------------
/// </summary>

public class ScrUI : MonoBehaviour
{
    [SerializeField]
    Text puntuacio; // per accedir a l'element de la UI
    
    [SerializeField]
    Text pickupRestants;

    [SerializeField]
    Text temps; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntuacio.text = "Puntuació: " + ScrControlGame.punts;
        pickupRestants.text = "Pickups: " + ScrControlGame.pickupRestants;
        temps.text = "Temps: " + Time.fixedTime;


    }
}
