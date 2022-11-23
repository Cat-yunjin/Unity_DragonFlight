using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Coin : MonoBehaviour
{

    public float rotateSpeed = 180f;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.position.y < -1f) //¸ø¸ÔÀ¸¸é ÆÄ±«
        //{
        //    Destroy(gameObject);
        //}
        //transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    }
}