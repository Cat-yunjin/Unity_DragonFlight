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
    private void OnTriggerEnter(Collider collision) // �浹�ϴ� ���� �۵�
<<<<<<< HEAD:NalalaYongari/Assets/SourceCodes/Damaged1.cs
=======
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
>>>>>>> 253d4ef4 (개요 : 충돌 판정 collider를 trigger을 사용함):NalalaYongari/Assets/Damaged1.cs
    {
        if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "meteo")
        {
            Destroy(gameObject);
        }
    }
<<<<<<< HEAD:NalalaYongari/Assets/SourceCodes/Damaged1.cs
    private void OnTriggerExit(Collider collision) // �浹�� ���� ���� �۵�
    {

    }
    private void OnTriggerStay(Collider collision) // �浹�ϴ� ���� �۵�
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
>>>>>>> 253d4ef4 (개요 : 충돌 판정 collider를 trigger을 사용함):NalalaYongari/Assets/Damaged1.cs
    */
}
