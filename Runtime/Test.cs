using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] int counter = 0;
    [SerializeField] int limit = 2000;
    
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        // v1.0.0 => 2000
        // v1.0.1 => 1000
        // v1.0.2 => 3000
        // v1.0.3 => 500
        if (counter > limit)
        {
            counter = 0;
        }
    }
}
