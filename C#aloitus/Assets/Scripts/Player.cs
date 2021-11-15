using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    Rigidbody rb;
    public Light myLight;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    /* kaikki näiden merkkien välissä
     on
     kommenttia 
     */


    // Update is called once per frame
    void Update()
    {
        // Turn on the light

        /*if (Input.GetKeyDown(KeyCode.L))
        {

            myLight.enabled = true;
        }

        if (Input.GetKeyUp(KeyCode.L))
        {
            myLight.enabled = false;
        }
        */

        //Switch the light on and off


         if (Input.GetKeyDown(KeyCode.L))
         {
            myLight.enabled = !myLight.enabled;
         }





        // Change the color of the gameobject


        if (Input.GetKeyDown(KeyCode.Y))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }


        // Move the gameobject


        // Move the gameobject

        if (Input.GetKeyDown(KeyCode.U))
        {
            rb.AddForce(Vector3.up * 500f);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = Vector3.forward * 10f;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = Vector3.back * 10f;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = Vector3.right * 10f;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = Vector3.left * 10f;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Collectible")
        {
            // Let´s collect things
            Destroy(collision.gameObject);
        }

        // Let´s get destroyed by enemy
        if (collision.gameObject.tag == "Enemy")
        {
           // Destroy(gameObject);

            SceneManager.LoadScene("GameOver");                       
        }






    }





}
