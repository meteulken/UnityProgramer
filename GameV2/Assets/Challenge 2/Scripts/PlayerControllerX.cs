using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float delay = 0.3f; // İstenilen gecikme süresi
    private float lastTimePressed = -1.0f; // Son basılma zamanı

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time - lastTimePressed >= delay)
            {
                // Tuşa basıldığında ve gecikme süresi geçtiğinde burası çalışır
                lastTimePressed = Time.time;
                // Burada yapmak istediğiniz işlemleri gerçekleştirebilirsiniz
                 Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }
    }
}
