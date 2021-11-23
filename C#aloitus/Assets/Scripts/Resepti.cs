using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resepti : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print ("Terve teille silkohapset");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnEnable()
    {
        print(" Inside OnEnable");
    }

    void OnDisable()
    {
        print(" Inside OnDisable");
    }
}
