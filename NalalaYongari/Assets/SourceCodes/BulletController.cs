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
