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
        if (collision.gameObject.tag == "meteo") // 우리드래곤이 운석하고 부딪히면
        {
            print("우리드래곤이 운석하고 부딪힘");
        }
    }
}
