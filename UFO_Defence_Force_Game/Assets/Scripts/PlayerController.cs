using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 20.0f;
    public float xRange = 35.5f;

    public Transform blaster;
    public GameObject blasterBolt;

    // Update is called once per frame
    void Update()
    {
        // Set horizontalInput to get values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        // Moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        
        // Keep player in bounds
        // Left side wall
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // Right side wall
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //if space is pressed, fire blaster
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //create blaster bolt at the blaster position, keeping object rotation
            Instantiate(blasterBolt, blaster.transform.position, blasterBolt.transform.rotation);
        }
    }

    // Delete any object with a trigger that hits the player
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
