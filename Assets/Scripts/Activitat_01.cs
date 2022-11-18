using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activitat_01 : MonoBehaviour
{
    public GameObject prefabSphere;

    //Variable to keep count of the number of spheres and waves
    private int numSphere = 1;
    private int numWave = 1;

    //Variables to set spawn bounds
    private int rangeX = 7;
    private int rangeY = 5;
    private int rangeZ = 5;

    private void Update()
    {
        //If de number of spheres drops down to 0 we call the GenerateSphere function
        if (numSphere == 0)
        {
            GenerateSphere(numWave);
        }
    }

    //Function to generate the nummber of spheres so it matches the number of waves
    public void GenerateSphere (int spheresToGenerate)
    {
        //Add +1 to the number of waves
        numWave++;
        //Generate a sphere in a random position as many times as waves we have won
        for (int i = 0; i < numWave; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(rangeX,-rangeX), Random.Range(rangeY,-rangeY), Random.Range(rangeZ,0));
            GameObject obj = Instantiate(prefabSphere);
            obj.transform.position = randomPosition; 
            //We set the number of spheres to be the same as the number of waves
            numSphere = numWave;
        }
    }

    //Function to subtract a sphere
    public void AddPoint()
    {
        numSphere--; 
    }
}