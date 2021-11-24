using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taulukot2 : MonoBehaviour
{
    public GameObject[] palikat;

    public Color[] colors;
    
    // Start is called before the first frame update
    void Start()
    {
        // Destroy ( palikat[2] );

        // Annetaan Capsule -komponentille keltainen väri colors -taulukosta

        palikat[0].GetComponent<Renderer>().material.color = colors[0];

        palikat[1].GetComponent<Renderer>().material.color = colors[1];

        palikat[2].GetComponent<Renderer>().material.color = colors[2];

        palikat[3].GetComponent<Renderer>().material.color = colors[3];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
