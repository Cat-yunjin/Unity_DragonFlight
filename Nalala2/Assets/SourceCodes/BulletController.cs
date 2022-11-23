using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
   
    Transform bullet;
    float speed = 0.23f;
    void Start()
    {
        bullet = transform;
<<<<<<< HEAD:Nalala2/Assets/SourceCodes/BulletController.cs
        
=======
>>>>>>> 26656c70 (.gitattributes 넣고 재도전):NalalaYongari/Assets/SourceCodes/BulletController.cs
    }
    
    // Update is called once per frame
    void Update()
    {
        bullet.Translate(new Vector3(0, speed, 0));
        if (transform.position.y > 15.0f)
        {
            Destroy(gameObject);
        }
    }

    
}
