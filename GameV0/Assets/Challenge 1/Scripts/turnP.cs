using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnP : MonoBehaviour
{
    public GameObject player;
    private Vector3 pervave;
    public float verticalInput;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void    Update()
    {

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        player.transform.Rotate(0,0,2.5f);

        if(verticalInput > 0 || horizontalInput > 0)
        {
            player.transform.Rotate(0,0,5);
        }
        else if(verticalInput < 0 || horizontalInput < 0)
        {
            player.transform.Rotate(0,0,-5);
        }
    }
}
