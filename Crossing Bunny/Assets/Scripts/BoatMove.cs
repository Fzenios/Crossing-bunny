using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMove : MonoBehaviour
{
   public float BoatSpeed;     

    void Start() 
    {
        int TruckSortLayer = Random.Range(1,1000);
        GetComponent<SpriteRenderer>().sortingOrder = TruckSortLayer;       
    } 
    void Update()
    {
        transform.Translate(Vector3.right * BoatSpeed * Time.deltaTime);
        if(transform.position.x > 12)
        {
            Destroy(gameObject);
        }
    }
}
