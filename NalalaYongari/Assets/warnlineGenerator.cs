using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warnlineGenerator : MonoBehaviour
{
    float delta = 0f;
    float span = 8.0f; // 8�ʸ��� warnline ����

    public GameObject warnlinePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;

            GameObject warnline = Instantiate(warnlinePrefab);

            // plane�� ��¦ ���� warnline ���� ok
            // warnline�� �巡�� �����ӿ� ���� ���� ������ fail
            // warnline�� 2�� ���� �����ϴٰ� �����ϰ� ������ ��ġ ��� fail
            // ������ ��ġ�� � generator ��ġ
            // �ű� ������ ��� ������


                
            warnline.transform.position = new Vector3(GameObject.Find("weDragon").transform.position.x, 10.0f, 8.9f);

        }
    }
}
