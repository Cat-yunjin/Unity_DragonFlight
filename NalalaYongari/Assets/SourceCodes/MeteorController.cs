using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour
{

    GameObject weDragon;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0); // �����Ӹ��� ������� ����

        // ȭ�� ������ ������ � �Ҹ�
        if (transform.position.y < -1.0f)
        {
            Destroy(gameObject);
        }
    }
}