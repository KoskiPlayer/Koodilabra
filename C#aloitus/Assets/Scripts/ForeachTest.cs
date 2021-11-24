using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachTest : MonoBehaviour
{
    public GameObject[] objects;    
    
    void Start()
    {
        foreach(GameObject o in objects)
        {
            o.SetActive(true);

            //Tuhotaan kaikki taulukon peliobjektit
            //Destroy(o);
        }
    }
}
