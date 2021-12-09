using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    Rigidbody rb;
    public Light myLight;

    public float rotatespeed;

    // Start is called before the first frame update
    void Start()
    {

        //print ("terve vaan");

        Testifunktio();

        rb = GetComponent<Rigidbody>();
    }

    /* kaikki n�iden merkkien v�liss�
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
            rb.velocity = Vector3.up * 10;
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            rb.velocity = Vector3.down * 10;
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

        //rotate gameobject

        transform.Rotate(0, rotatespeed, 0);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Collectible")
        {
            // Increment score
            GameControl.instance.IncrementScore();
            
            // Let�s collect things
            Destroy(collision.gameObject);
        }

        // Let�s get destroyed by enemy
        if (collision.gameObject.tag == "Enemy")
        {
            // Destroy(gameObject);
            
            //SceneManager.LoadScene("GameOver");  

            // Decrease Lives
            GameControl.instance.DecreaseLife();
            Destroy(collision.gameObject);

        }
            
    }


    void Testifunktio()
    {
        print("Testifunktio kutsuttu!");
    }


}
