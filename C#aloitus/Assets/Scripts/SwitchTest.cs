using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTest : MonoBehaviour
{
    public int power = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        //Testataan muuttujan power arvoa. Arvoilla 1,2,3 kirjoitetaan teksti, muilla arvoilla
        //kirjoitetaan default -arvo: You Are Not a Player.
        switch (power)
        {
            case 1:
                print("You Are Beginner Player");
                break;
            case 2:
                print("You Are Intermediate Player");
                break;
            case 3:
                print("You Are Advanced Player");
                break;
            default:
                print("You Are Not a Player");
                break;
        }
    }
}
