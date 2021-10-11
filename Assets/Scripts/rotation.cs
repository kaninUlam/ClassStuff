using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = transform.localRotation * Quaternion.Euler(0, speed * Time.deltaTime, 0);
        if (Input.GetKey("space"))
        {
            
            transform.localRotation = transform.localRotation * Quaternion.Euler(0, speed * Time.deltaTime, 0);
        }
    }
}
