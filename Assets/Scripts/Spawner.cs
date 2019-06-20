using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner    : MonoBehaviour
{
    public GameObject pod;
    public GameObject[] prefab;
    // Start is called before the first frame update
    public static void T( int i , int j, int k, GameObject prefab )
    {

        MG.spawn(i, j, k, prefab);
        MG.spawn(i, j , k-1, prefab);
        MG.spawn(i, j , k+1, prefab);
        MG.spawn(i, j-1 , k, prefab);
        //promenliva prashta -1

    }



    void Start()
    {

        MG.grid[1, 3, 3] = pod.transform;
        MG.grid[1, 1, 2] = pod.transform;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {

            T(1, 9, 3, prefab[0]);
            MG.updater();

        }
        if (Input.GetKeyDown("space"))
        {
           
            // Destroy(GameObject.Find("0"));
          /* DesmeObject.FindWithTag(MG.grid[1, 2, 3].tag));
            Debug.Log(GameObject.Find(MG.grid[1, 2, 3].name));*/
            /*MG.movedown();
            MG.updater(); */

        }


    }
}
