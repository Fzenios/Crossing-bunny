using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SxediaSpownScr : MonoBehaviour
{
    // Start is called before the first frame update
    public static int SxediaCount = 0;
    public int SxediaCountMax = 1;
    public GameObject sxediaright;
    public GameObject sxedialeft;
    public Transform SpownPointRight;
    public Transform SpownPointLeft;

    private void Start() 
    {
        InvokeRepeating("SxediaSpowner",1,5); 
    }
    void Update()
    {

    }
    void SxediaSpowner()
    {
        //Instantiate(sxediaright,SpownPointRight.position,Quaternion.identity);
        Instantiate(sxedialeft,SpownPointLeft.position,Quaternion.identity);
    }
}
