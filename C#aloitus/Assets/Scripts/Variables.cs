using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
   //kokonaisluku int
    int score = 10;

   //murtoluku float
    float speed = 2.5f;

    //kirjain char
    char character = 'A';

    // teksti string
    string nimi = " Markku ";

    // Start is called before the first frame update
    void Start()
    {

        //print(10);
        print(score);
        print(speed);
        print(character);
        print(nimi);

    }

}
