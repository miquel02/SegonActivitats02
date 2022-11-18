using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acitvitat_01_2 : MonoBehaviour
{
    private Activitat_01 manager;

    private void Start()
    {
        //We acces the main script
        manager = FindObjectOfType<Activitat_01>();
    }

    // If the mouse is over the GameObject 
    private void OnMouseDown()
    {
        //We call the addpoint function in the main script
        manager.AddPoint();

        //Destroy the sphere
        Destroy(gameObject);
    }
}