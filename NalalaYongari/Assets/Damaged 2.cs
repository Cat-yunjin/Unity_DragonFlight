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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "meteo") // �츮�巡���� ��ϰ� �ε�����
        {
            print("�츮�巡���� ��ϰ� �ε���");
        }
    }
}
