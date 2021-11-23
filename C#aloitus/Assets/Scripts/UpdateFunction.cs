using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateFunction : MonoBehaviour
{ 

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(speed, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(speed, 0, 0);
    }
}

