using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaged: MonoBehaviour
{
    public GameObject itemPrefab;
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
<<<<<<< HEAD:NalalaYongari/Assets/SourceCodes/Damaged.cs
        if (collision.gameObject.tag == "bullet")
=======
        if (collision.gameObject.tag == "project" || collision.gameObject.tag == "meteo") // ���׵巡���� bullet�̶� �ε����� ������

>>>>>>> 253d4ef4 (개요 : 충돌 판정 collider를 trigger을 사용함):NalalaYongari/Assets/Damaged.cs
        {
            int point = Random.Range(0, 100);
            if (point <= 50)
            {
                GameObject drop_item = Instantiate(itemPrefab);
                drop_item.transform.position = this.transform.position;
            }
            Destroy(this.gameObject);
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
