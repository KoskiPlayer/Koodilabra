using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddAndMultiplyTask : MonoBehaviour
{
   int Tulos;
        
        
    void Start()
    {
        Tulos = AddAndMultiply(3, 6, 35);
        Debug.Log(Tulos);

        Debug.Log(AddAndMultiply(3, 6, 35));        // 315
        Debug.Log(AddAndMultiply(-12, 5, 17));      // -119
        Debug.Log(AddAndMultiply(-40, 50, 60));     // 600
       // Debug.Log(AddAndMultiply(1.7, 9.9, 0.01));  // 0.116
    }

    int AddAndMultiply(int a, int b, int c)
    {
        int result;
        result = (a + b) * c;
        return result;
    }


}
