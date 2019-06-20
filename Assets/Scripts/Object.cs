using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    bool executed = false;
    bool  intro;//------------------------------------------------------IN--------------------------------------------
    public static GameObject[] AllTagged;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Debug.Log("EXECUTED   " + executed);
        Debug.Log("TAG   " + gameObject.CompareTag("Static"));
        Debug.Log("2222222222" + intro);
        Debug.Log(gameObject.CompareTag("Static") && executed);*/

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------//



        //---------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /*
                                if (gameObject.CompareTag("Static") && executed)
                                {

                                MG.grid[(int)transform.position.x, (int)transform.position.y + 1, (int)transform.position.z] = transform;
                                MG.grid[(int)transform.position.x, (int)transform.position.y, (int)transform.position.z] = null;
                                transform.position = new Vector3(transform.position.x, transform.position.y + 1.0f, transform.position.z);
                                Debug.Log("Fay");
                                //intro = false;
                                executed = false;
                                }*/




        if (Input.GetKeyDown("space"))
        {
            MG.trig = true;
            //MG.moveCheck();
        }
             if (gameObject.CompareTag("Dynamic") && MG.trig)
             {


                  MG.grid[(int)transform.position.x, (int)transform.position.y - 1, (int)transform.position.z] = transform;
                  MG.grid[(int)transform.position.x, (int)transform.position.y, (int)transform.position.z] = null;
                  transform.position = new Vector3(transform.position.x, transform.position.y - 1.0f, transform.position.z);

             }
            }  
        }

    










