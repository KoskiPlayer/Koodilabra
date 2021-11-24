using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taulukot1 : MonoBehaviour
{
    // Tallennetaan data suoraan Unity Editorista
    public int[] score;

    // Tallennetaan data koodin sisällä
    string[] nimet = new string[4];
    
    // Start is called before the first frame update
    void Start()
    {        
        // Tallennetaan nimidata
        nimet[0] = "Markku";
        nimet[1] = "Riitta";
        nimet[2] = "Minna";
        nimet[3] = "Mikko";
                
        // Haetaan data taulukosta ja printataan konsoliin
        print(score.Length);
        print(score[2]);
        print(nimet[3]);
    }        
}
