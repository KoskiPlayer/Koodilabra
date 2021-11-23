using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElseStatements : MonoBehaviour
{
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        if (score <= 0)
        {
            // suoritetaan, jos ehto on tosi
            print(" Game over ");
        }

        else if (score > 0 && score <= 10)
        {
            print(" Level 1 ");
        }

        else if (score > 10)
        {
            print(" Level 2 ");
        }

        else
        {
            print(" Game running ");
        }
    }
}
