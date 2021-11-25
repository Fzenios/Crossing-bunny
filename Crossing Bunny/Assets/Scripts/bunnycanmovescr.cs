using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bunnycanmovescr : MonoBehaviour
{
    public bunny_scr bunny_scr;  
    
    public void bunnycanmovefunc()
    {
        bunny_scr.bunnywait = true;
        bunny_scr.bunnycanmove = true;
    }
}
