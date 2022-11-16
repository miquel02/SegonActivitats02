using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activitat_01 : MonoBehaviour
{
    public GameObject prefabSphere;
    [SerializeField]private int numSphere = 1;
    [SerializeField] private int numWave = 1;
    public Vector3 randomPos;
    public int rangeX = 7;
    public int rangeY = 5;
    public int rangeZ = 5;



    private void Update()
    {
        if (numSphere == 0)
        {
            GenerateSphere(numWave);
        }
    }

    public void GenerateSphere (int spheresToGenerate)
    {
        numWave++;
    
        for (int i = 0; i < numWave; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(rangeX,-rangeX), Random.Range(rangeY,-rangeY), Random.Range(rangeZ,0));
            GameObject obj = Instantiate(prefabSphere);
            obj.transform.position = randomPosition; 
            
            numSphere = numWave;
        }

        Debug.Log("has passatd de ronda");
    }

    public void AddPoint()
    {
        numSphere--; 
    }
}