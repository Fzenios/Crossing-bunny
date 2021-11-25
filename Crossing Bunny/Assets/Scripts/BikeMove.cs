using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeMove : MonoBehaviour
{
    public float BikeSpeed;  
    void Update()
    {
        transform.Translate(Vector3.left * BikeSpeed * Time.deltaTime);
        if(transform.position.x < -12)
        {
            Destroy(gameObject);
        }
    }
}
