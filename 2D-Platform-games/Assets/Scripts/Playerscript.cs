using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscript : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10f;
    // public float leftBoundary = -10f;
    // public float rightBoundary = 10f;
    public float xRange = 19f;
    public GameObject projectilePrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            // karakter -10 dan daha ileriye gidemiyor
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }
        if (transform.position.x >xRange)
        {
            // karakter 10 dan daha ileriye gidemiyor
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }
        if (Input.GetKeyDown(KeyCode.Space)){
            Vector3 PizzaPosition = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
            Instantiate(projectilePrefab, PizzaPosition, projectilePrefab.transform.rotation);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
