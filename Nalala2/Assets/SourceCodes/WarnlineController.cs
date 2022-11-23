using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarnlineController : MonoBehaviour
{
    Vector3 weDragonPos;
    Transform warnline;
    //float speed = 0.5f;
    // public GameObject meteoPrefab;
    // GameObject meteo;
    float point;
    public GameObject meteorPrefab;
    float delta = 0f;

    // Start is called before the first frame update
    void Start()
    {
        point = GameObject.Find("weDragon").transform.position.x;

       
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(this.delta >= 2f){
            Destroy(gameObject);
            GameObject meteor = Instantiate(meteorPrefab);
            meteor.transform.position = new Vector3(point, 15.0f, 8.0f);
        }
        // warnline은 x축으로만 평행하게 움직임
        // generator에서 받아온 wedragon의 최종 위치에서 운석을 생성

        //Vector3 differ = GameObject.Find("weDragon").transform.position - point;
        //Vector3 pos = transform.position;

        ///pos.x += differ.x * Time.deltaTime * speed; // 이동거리 보정

        //transform.position = pos; // 이동
        //point = GameObject.Find("weDragon").transform.position; // 왜 안움직이는지 모르겠듬,,

        //meteo = Instantiate(meteoPrefab);

        //meteo.transform.position = new Vector3(GameObject.Find("warnline").transform.position.x,
        //       GameObject.Find("warnline").transform.position.y + 15.0f, 8);

    }
}