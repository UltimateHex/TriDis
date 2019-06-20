using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staticar : MonoBehaviour
{
    bool staticer = false;
    // Start is called before the first frame update
    void Start()
    {
          
       
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 0)
        {
            staticer = true;

        }
        if (staticer)
        {

            Destroy(gameObject);
        }
    }
}
