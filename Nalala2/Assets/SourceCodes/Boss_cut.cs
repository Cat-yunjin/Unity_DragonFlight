using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_cut : MonoBehaviour
{
    int coll_num = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            coll_num++;
        }
        if (coll_num > 30)
        {
            coll_num = 0;
            EnemyGenerator.boss_chk = false;
            Destroy(this.gameObject);
        }
    }
}