using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newaaa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public static void Del()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log(MG.grid[1, 2, 3].name);
          
            /* MG.movedown();
             MG.updater();*/
        }
    }
    void Update()
    {
        /*if (this.gameObject.CompareTag("Del"))
        {
            Destroy(gameObject);    
        }*/
    }
}
