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
