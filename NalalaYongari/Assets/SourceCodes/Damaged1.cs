using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaged1 : MonoBehaviour
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
        if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "meteo")
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerExit(Collider collision) // �浹�� ���� ���� �۵�
    {

    }
    private void OnTriggerStay(Collider collision) // �浹�ϴ� ���� �۵�
    {

    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "meteo")
        {
            Destroy(gameObject);
        }
    }
    */
}