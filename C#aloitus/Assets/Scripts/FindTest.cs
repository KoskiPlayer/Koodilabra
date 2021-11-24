using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTest : MonoBehaviour
{
    GameObject searchObj;
    GameObject[] enemies;

    // Start is called before the first frame update
    void Start()
    {
        //searchObj = GameObject.Find("Cube (1)/Cube2/Enemy");

        //searchObj = GameObject.FindWithTag("Enemy");

        //enemies = GameObject.FindGameObjectsWithTag("Enemy");

        //searchObj = GameObject.Find("Cube (1)");

        //Destroy(searchObj);

        //foreach (GameObject enemy in enemies)
        //{       		
        //    			Destroy (enemy);       
        //}

        GameObject.Find("Cube (1)").SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
