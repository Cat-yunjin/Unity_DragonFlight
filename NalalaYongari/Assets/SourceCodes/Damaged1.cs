using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaged1: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collision) // Ãæµ¹ÇÏ´Â ¼ø°£ ÀÛµ¿
<<<<<<< HEAD:NalalaYongari/Assets/SourceCodes/Damaged1.cs
=======
    {
        if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "meteo")
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerExit(Collider collision) // Ãæµ¹ÀÌ ³¡³­ ¼ø°£ ÀÛµ¿
    {

    }
    private void OnTriggerStay(Collider collision) // Ãæµ¹ÇÏ´Â ¼ø°£ ÀÛµ¿
    {

    }

    /*
    private void OnCollisionEnter(Collision collision)
>>>>>>> 253d4ef4 (ê°œìš” : ì¶©ëŒ íŒì • colliderë¥¼ triggerì„ ì‚¬ìš©í•¨):NalalaYongari/Assets/Damaged1.cs
    {
        if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "meteo")
        {
            Destroy(gameObject);
        }
    }
<<<<<<< HEAD:NalalaYongari/Assets/SourceCodes/Damaged1.cs
    private void OnTriggerExit(Collider collision) // Ãæµ¹ÀÌ ³¡³­ ¼ø°£ ÀÛµ¿
    {

    }
    private void OnTriggerStay(Collider collision) // Ãæµ¹ÇÏ´Â ¼ø°£ ÀÛµ¿
    {

    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
=======
>>>>>>> 253d4ef4 (ê°œìš” : ì¶©ëŒ íŒì • colliderë¥¼ triggerì„ ì‚¬ìš©í•¨):NalalaYongari/Assets/Damaged1.cs
    */
}
