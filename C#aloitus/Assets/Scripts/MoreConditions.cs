using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreConditions : MonoBehaviour
{
    public string name;

    // Start is called before the first frame update
    void Start()
    {
        if ( name == "Markku")
        {
            print(" Terve Markku ");
        }
        else
        {
            print(" Sinä et ole Markku ");
        }

    }
}
