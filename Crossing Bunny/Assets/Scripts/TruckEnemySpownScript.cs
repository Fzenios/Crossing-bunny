using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckEnemySpownScript : MonoBehaviour
{
    public GameObject[] Enemylist;
    public float TimeBetweenTruckSpowns = 1;
    public GameObject Bike;
    public int BikeTimer = 5;
    

    void Start() 
    {
        InvokeRepeating("TruckSpown", 0, TimeBetweenTruckSpowns);
        InvokeRepeating("BikeSpown", 0, BikeTimer);
    }

    void TruckSpown()
    {
        float Randomy = Random.Range(-1.6f,0.82f);
        float Randomx = Random.Range(15f,18f);
        int RandomTrack = Random.Range(0,5);
        Vector3 StartPoint = new Vector3(Randomx,Randomy,0);
        Instantiate(Enemylist[RandomTrack],StartPoint,Quaternion.identity); 
    }
    void BikeSpown()
    {
        Vector3 BikeStartPoint = new Vector3(12,1.8f,0);
        Instantiate(Bike,BikeStartPoint,Quaternion.identity);   
    }
}
