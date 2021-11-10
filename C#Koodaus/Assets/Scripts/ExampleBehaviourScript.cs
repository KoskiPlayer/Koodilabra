using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ExampleBehaviourScript : MonoBehaviour
{
    Rigidbody rb;

    public Light myLight;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {


        // Turn on the light

        if (Input.GetKeyDown(KeyCode.L))
        {

            myLight.enabled = true;
        }

        if (Input.GetKeyUp(KeyCode.L))
        {
            myLight.enabled = false;
        }


        // Switch the light on and off

       // if (Input.GetKeyDown(KeyCode.L))
       // {

            //myLight.enabled = !myLight.enabled;
        //}

        // Change the color of the gameobject

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

        if (Input.GetKeyDown(KeyCode.U))
        {
            rb.AddForce(Vector3.up * 500);
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

        // Destroy the gameobject

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }

        // Load a new scene

        if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level2");
        }

    }

    // Destroy the gameobject with the mouse
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

   
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Collectible")
        {
            // Let´s collect things
            Destroy(collision.gameObject);
        }

        // Let´s get destroyed by enemy
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }


    }
   

}
