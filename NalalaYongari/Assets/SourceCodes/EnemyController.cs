using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.1f, 0);

<<<<<<< HEAD:NalalaYongari/Assets/SourceCodes/EnemyController.cs
        if (transform.position.y < -1.0f)
=======
    }


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "project" || collision.gameObject.tag == "meteo") // ���׵巡���� bullet�̶� �ε����� ������

>>>>>>> 253d4ef4 (개요 : 충돌 판정 collider를 trigger을 사용함):NalalaYongari/Assets/Damaged.cs
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
