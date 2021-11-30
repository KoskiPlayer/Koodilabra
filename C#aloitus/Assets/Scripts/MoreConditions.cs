using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreConditions : MonoBehaviour
{
    public string nimi;

    // Start is called before the first frame update
    void Start()
    {
        if ( nimi == "Markku")
        {
            print(" Terve Markku ");
        }
        else
        {
            print(" Sinä et ole Markku ");
        }

    }
}
