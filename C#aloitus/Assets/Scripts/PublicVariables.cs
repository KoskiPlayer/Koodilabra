using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicVariables : MonoBehaviour
{
    //kokonaisluku int
    public int score = 10;
   
    // teksti string
    public string nimi = " Markku ";

    // Start is called before the first frame update
    void Start()
    {               
        print(" My name is " + nimi);
        print(" My score is " + score);
    }       
}
