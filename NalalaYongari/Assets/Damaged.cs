using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaged: MonoBehaviour
{
    public GameObject pro1Prefab;
    public GameObject pro2Prefab;
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
        if (collision.gameObject.tag == "bullet")
        {
            int point = Random.Range(0, 100);
            if (point %10 == 1)
            {
                GameObject drop_item = Instantiate(pro1Prefab);
                drop_item.transform.position = this.transform.position;
            }
            if (point%20 == 1){
                GameObject drop_item = Instantiate(pro2Prefab);
                drop_item.transform.position = this.transform.position;
            }
            Destroy(this.gameObject);
        }
    }
}
