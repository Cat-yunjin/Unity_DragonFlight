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
    private void OnTriggerEnter(Collider collision) // �浹�ϴ� ���� �۵�
    {
        if (collision.gameObject.tag == "enemy" )
        {
            Destroy(gameObject);
        }
    }
    
}