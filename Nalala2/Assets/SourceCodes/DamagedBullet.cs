using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagedBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collision) // 충돌하는 순간 작동
    {
        if (collision.gameObject.tag == "enemy" )
        {
            Destroy(gameObject);
        }
    }
    
}