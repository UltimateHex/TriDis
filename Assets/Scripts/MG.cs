using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG : MonoBehaviour
{
    
    public static int x = 15;
    public static int y = 15;
    public static int z = 15;
    [HideInInspector]
    public static GameObject[] testa;
    public static Transform[,,] grid = new Transform[x, z, y];
    public static int g = 1;
    public static GameObject[] AllTagged;
    public static bool trig = false;

    public static void updater()
        {
        Debug.Log("vliza");
        for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < z; j++)
                {
                    for (int k = 0; k < y; k++)
                    {
                   
                        if (grid[i, j, k] != null)
                        {
                           

                            if (grid[i, j, k].gameObject.CompareTag("Dynamic"))
                            {

                            Debug.Log("INSTANTIIRA SE");
                               //Vector3 pos = new Vector3(i, k, j);
                                Instantiate(grid[i, j, k], new Vector3(i, j, k), Quaternion.identity);
                            }
                        if (grid[i, j, k].gameObject.CompareTag("Del"))
                        {
                            Debug.Log("w del updater" + grid[i, j, k].gameObject.tag);
                            Debug.Log(" ime" + grid[i, j, k]);
                            Debug.Log(i + " " + j + " " + k);

                            Destroy(GameObject.FindWithTag("Del"));
                        }

                    }
                    }
                }
            }


        }
        public static void movedown() {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < z; j++)
                {
                    for (int k = 0; k < y; k++)
                    {
                        if (grid[i, j, k] != null)
                        {
                            if (grid[i, j, k].gameObject.CompareTag("Dynamic"))
                            {
                               if(grid[i , (j-1), k] == null)
                                {



                                grid[i, (j - 1), k] = grid[i, j, k];



                                //grid[i, j, k] = Spawner.Del.transform;
                                // grid[i, (j - 1), k].gameObject.tag = "Dynamic";

                                //  GameObject.Find(grid[i, j, k].name).tag = "Del";
                                /* Debug.Log("dd"+grid[i, j, k].gameObject.tag);
                                 Debug.Log(grid[i, (j-1), k].gameObject.tag);*/
                                Debug.Log("TOVA:  " + GameObject.Find(grid[i,j,k].name));

                                }
                            }
                        }
                    }
                }
            }



    }

    public static void spawn(int h , int v , int hh ,  GameObject prefab)
    {
     
        GameObject aa = prefab;
        MG.grid[h, v, hh] = prefab.transform;
        MG.grid[h, v, hh].gameObject.tag = "Dynamic";
        grid[h, v, hh].gameObject.name = g.ToString();
        g++;
    }
    public static void moveCheck()
    {

        for (int i = 0; i < MG.x; i++)
        {
            for (int j = 0; j < MG.z; j++)
            {
                for (int k = 0; k < MG.y; k++)
                {

                    if (MG.grid[i, j, k] != null)
                    {
                        if (MG.grid[i, j, k].gameObject.CompareTag("Dynamic"))
                        {



                            if (MG.grid[i, j - 1, k] != null)
                            {
                                if (MG.grid[i, j - 1, k].gameObject.CompareTag("Static"))
                                {
                                    AllTagged = GameObject.FindGameObjectsWithTag("Dynamic");
                                    foreach (GameObject ToGetStatic in AllTagged)
                                    {

                                        Debug.Log(MG.grid[i, j - 1, k]  );
                                        ToGetStatic.tag = "Static";
                                        MG.grid[(int)ToGetStatic.transform.position.x, (int)ToGetStatic.transform.position.y, (int)ToGetStatic.transform.position.z].tag = "Static";
                                        
                                    }
                                }


                            }


                        }
                    }
                }
            }
        }

    }
    /*public static void zamruzvane()
    {
        foreach (gameObject MG.grid[,,]in AllTagged)
                    {

        }
    }*/
    



}
