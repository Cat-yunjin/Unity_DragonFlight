using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaged: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "project" || collision.gameObject.tag == "meteo") // ���׵巡���� bullet�̶� �ε����� ������

        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerExit(Collider collision)
    {

    }
    private void OnTriggerStay(Collider collision)
    {

    }


    /* collision���� ó������ �� 
   private void OnCollisionEnter(Collision collision)
   {
       if (collision.gameObject.tag == "project" || collision.gameObject.tag == "meteo") // ���׵巡���� bullet�̶� �ε����� ������

       {
           Destroy(gameObject);
       }
   }
    */
}
