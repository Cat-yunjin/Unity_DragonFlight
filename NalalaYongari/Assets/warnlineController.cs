using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warnlineController : MonoBehaviour 
{
    Vector3 weDragonPos;
    Transform warnline;
    //float speed = 0.5f;
   // public GameObject meteoPrefab;
   // GameObject meteo;
    Vector3 point;
    

    // Start is called before the first frame update
    void Start()
    {
        warnline = transform;
        point = GameObject.Find("weDragon").transform.position;
        //GameObject meteo = Instantiate(meteoPrefab);
        Destroy(gameObject, 2f);
        

    }

    // Update is called once per frame
    void Update()
    {
        // warnline�� x�����θ� �����ϰ� ������
        // generator���� �޾ƿ� wedragon�� ���� ��ġ���� ��� ����

        //Vector3 differ = GameObject.Find("weDragon").transform.position - point;
        //Vector3 pos = transform.position;

        ///pos.x += differ.x * Time.deltaTime * speed; // �̵��Ÿ� ����

        //transform.position = pos; // �̵�
        //point = GameObject.Find("weDragon").transform.position; // �� �ȿ����̴��� �𸣰ڵ�,,

        //meteo = Instantiate(meteoPrefab);

        //meteo.transform.position = new Vector3(GameObject.Find("warnline").transform.position.x,
         //       GameObject.Find("warnline").transform.position.y + 15.0f, 8);

    }
}
