using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScrpt : MonoBehaviour
{
    public GameObject LevelObject;

    void Start() 
    {
        openlevel(); 
    }
    public void openlevel()
    {
        LevelObject.SetActive(true);
    }


}
