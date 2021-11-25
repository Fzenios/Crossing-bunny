using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckMove : MonoBehaviour
{
    public float TruckSpeed;     

    void Start() 
    {
        //TruckSpeed = Random.Range(3f,7f); 
        int TruckSortLayer = Random.Range(2000,3000);
        GetComponent<SpriteRenderer>().sortingOrder = TruckSortLayer;       
    } 
    void Update()
    {
        transform.Translate(Vector3.left * TruckSpeed * Time.deltaTime);
        if(transform.position.x < -12)
        {
            Destroy(gameObject);
        }
    }
}
