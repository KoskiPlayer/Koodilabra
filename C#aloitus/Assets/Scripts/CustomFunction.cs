using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomFunction : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        //Kutsutaan Testfunction - funktiota
        TestFunction();
    }
   void TestFunction()
    {
        print (" Shoot ");
        print (" Destroy ");
        print (" Move ");
        transform.Translate(speed, 0, 0);
    }
}
