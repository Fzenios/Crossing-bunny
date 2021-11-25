using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatEnemyScript : MonoBehaviour
{
    public GameObject[] BoatEnemylist;
    public float TimeBetweenBoatSpowns = 3f;

    void Start() 
    {
        InvokeRepeating("BoatSpown", 0, TimeBetweenBoatSpowns);       
    }

    void BoatSpown()
    {
        float Randomx = Random.Range(-18f,-12f);
        int RandomBoat = Random.Range(0,2);
        Vector3 StartPoint = new Vector3(Randomx,2.8f,0);
        Instantiate(BoatEnemylist[RandomBoat],StartPoint,Quaternion.identity);

    
        
    }
}
