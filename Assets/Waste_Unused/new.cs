using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newaa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown("space"))
    {
        Debug.Log(MG.grid[1, 2, 3].name);
        Destroy(gameObject);
        /* MG.movedown();
         MG.updater();*/
    }
}
}
