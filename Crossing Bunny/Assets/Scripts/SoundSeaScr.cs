using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSeaScr : MonoBehaviour
{
    public bunny_scr bunny_scr;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player" && !bunny_scr.sxediatouch)
        {
            GetComponent<AudioSource>().Play();
        }    
    }

        void OnTriggerStay2D(Collider2D other) 
    {
        if(other.tag == "Player" && !bunny_scr.sxediatouch)
        {
            GetComponent<AudioSource>().Play();
        }           
    }
}
