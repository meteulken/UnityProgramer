using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;

    public float zRange = 3.0f;
    public float zRange2 = -1.0f;
    public GameObject projectilePrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }

        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y,transform.position.z);
        }

        if(transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x,transform.position.y,zRange);
        }
        if(transform.position.z < zRange2)
        {
            transform.position = new Vector3(transform.position.x,transform.position.y,zRange2);
        }

        horizontalInput = Input.GetAxis("Horizontal"); // A, D, Left, Right
        verticalInput = Input.GetAxis("Vertical"); // W, S, Up, Down

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 spawnPos = transform.position + transform.forward * 5.0f;
            Instantiate(projectilePrefab, spawnPos, projectilePrefab.transform.rotation);
        }
    }
}
