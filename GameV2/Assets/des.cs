using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class des : MonoBehaviour
{
    private float topBound = 25;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame  // -20 > -21
    void Update()
    {
        if(transform.position.x > topBound)
        {
            Destroy(gameObject);
        }
    }
}
