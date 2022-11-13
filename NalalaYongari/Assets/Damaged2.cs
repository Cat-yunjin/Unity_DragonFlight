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

    private void OnTriggerEnter(Collider collision) // 충돌하는 순간 작동
    {
        if (collision.gameObject.tag == "meteo") // 우리드래곤이 운석하고 부딪히면
        {
            Debug.Log("우리 드래곤이 운석하고 부딪힘");
            // 2번까지 부딪히는 거 가능, 3번 부터 죽음
        }
    }
    private void OnTriggerExit(Collider collision) // 충돌이 끝난 순간 작동
    {

    }
    private void OnTriggerStay(Collider collision) // 충돌하는 순간 작동
    {

    }
    /* 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "meteo") // 우리드래곤이 운석하고 부딪히면
        {
            Debug.Log("우리 드래곤이 운석하고 부딪힘");
            // 2번까지 부딪히는 거 가능, 3번 부터 죽음
        }
    }
    */
}
