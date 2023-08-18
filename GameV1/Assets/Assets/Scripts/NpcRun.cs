
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcRun : MonoBehaviour
{

    public float speed = 5.0f;
    public Vector3 hiz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
