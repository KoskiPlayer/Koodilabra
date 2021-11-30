using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }

        // Move the gameobject

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = Vector3.forward * 10f;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = Vector3.left * 10f;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = Vector3.right * 10f;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = Vector3.back * 10f;
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            rb.velocity = Vector3.up * 10f;
        }

    } // update loppuu t‰h‰n

    // ker‰ill‰‰n karkkeja
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Collectible")
        {
            // Let¥s collect things
            Destroy(collision.gameObject);
        }
    }


}
