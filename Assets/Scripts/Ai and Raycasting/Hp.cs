using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp : MonoBehaviour
{
    public int health = 10;
    public GameObject cube = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void damage()
    {
        if (health == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
