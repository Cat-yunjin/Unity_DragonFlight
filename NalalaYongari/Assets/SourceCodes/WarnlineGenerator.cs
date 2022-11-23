using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarnlineGenerator : MonoBehaviour
{
    float delta = 0f;
    float span = 3.0f; // 8�ʸ��� warnline ����

    public GameObject warnlinePrefab;
    public GameObject meteorPrefab;
    public GameObject warnmarkPrefab;
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
            float we_dragon_loc = GameObject.Find("weDragon").transform.position.x;

            GameObject warnline = Instantiate(warnlinePrefab);
            warnline.transform.position = new Vector3(we_dragon_loc, 10.0f, 8.9f);

            //GameObject warnmark = Instantiate(warnmarkPrefab);

            // plane�� ��¦ ���� warnline ���� ok
            // warnline�� �巡�� �����ӿ� ���� ���� ������ fail
            // warnline�� 2�� ���� �����ϴٰ� �����ϰ� ������ ��ġ ��� fail
            // ������ ��ġ�� � generator ��ġ
            // �ű� ������ ��� ������

            //warnmark.transform.position = new Vector3(GameObject.Find("weDragon").transform.position.x, 10.0f, 8.9f);

        }
    }
}