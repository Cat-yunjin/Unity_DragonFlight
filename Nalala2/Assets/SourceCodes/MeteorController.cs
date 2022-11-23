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

        // 화면 밖으로 나오면 운석 소멸

        transform.Translate(0, -0.15f, 0); // 프레임마다 등속으로 낙하
        if (transform.position.y < -1.0f)
        {
            Destroy(gameObject);
        }
    }
}