using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warnlineGenerator : MonoBehaviour
{
    float delta = 0f;
    float span = 8.0f; // 8초마다 warnline 생성

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

            // plane의 살짝 위에 warnline 생성 ok
            // warnline이 드래곤 움직임에 따라 같이 움직임 fail
            // warnline이 2초 정도 지속하다가 삭제하고 마지막 위치 기억 fail
            // 마지막 위치에 운석 generator 설치
            // 거기 위에서 운석이 떨어짐


                
            warnline.transform.position = new Vector3(GameObject.Find("weDragon").transform.position.x, 10.0f, 8.9f);

        }
    }
}
