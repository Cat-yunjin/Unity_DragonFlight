using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaged2 : MonoBehaviour
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
        if (collision.gameObject.tag == "meteo") // �츮�巡���� ��ϰ� �ε�����
        {
            Debug.Log("�츮 �巡���� ��ϰ� �ε���");
            // 2������ �ε����� �� ����, 3�� ���� ����
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
        if (collision.gameObject.tag == "meteo") // �츮�巡���� ��ϰ� �ε�����
        {
            Debug.Log("�츮 �巡���� ��ϰ� �ε���");
            // 2������ �ε����� �� ����, 3�� ���� ����
        }
    }
    */
}
