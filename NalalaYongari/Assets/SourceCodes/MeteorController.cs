using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        // ȭ�� ������ ������ � �Ҹ�

        transform.Translate(0, -0.15f, 0); // �����Ӹ��� ������� ����
        if (transform.position.y < -1.0f)
        {
            Destroy(gameObject);
        }
    }
}