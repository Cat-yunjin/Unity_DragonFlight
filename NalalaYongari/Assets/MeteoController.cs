using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoController : MonoBehaviour
{

    GameObject weDragon;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0); // 프레임마다 등속으로 낙하

        // 화면 밖으로 나오면 운석 소멸
        if (transform.position.y < -1.0f)
        {
            Destroy(gameObject);
        }
    }
}
