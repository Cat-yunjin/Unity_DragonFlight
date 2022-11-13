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
        if (collision.gameObject.tag == "project" || collision.gameObject.tag == "meteo") // À÷³×µå·¡°ïÀº bulletÀÌ¶û ºÎµúÈ÷¸é ¾ø¾îÁü

>>>>>>> origin/yunjin:NalalaYongari/Assets/Damaged.cs
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


    /* collisionÀ¸·Î Ã³¸®ÇßÀ» ¶§ 
   private void OnCollisionEnter(Collision collision)
   {
       if (collision.gameObject.tag == "project" || collision.gameObject.tag == "meteo") // À÷³×µå·¡°ïÀº bulletÀÌ¶û ºÎµúÈ÷¸é ¾ø¾îÁü

       {
           Destroy(gameObject);
       }
   }
    */
}
