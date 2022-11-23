using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagedTheirDragon : MonoBehaviour
{
    public GameObject itemPrefab;
    EnemyController ec;
    int damage;


    void Start()
    {
        GameObject go = GameObject.Find("BulletGenerator");
        damage = go.GetComponent<BulletGenerator>().damage;
    }

    void Update()
    {
        ec = this.gameObject.GetComponent<EnemyController>();
        if (ec.monster_data.hp <= 0)
        {
            int point = Random.Range(0, 100);
            GameObject drop_item;
            GameObject drop_coin;
            int item_code = -1;
            bool no_item = false;
            point = Random.Range(0, 100);
            if (point >= 96)
            {
                drop_item = Instantiate(itemPrefab);
                drop_item.transform.position = this.transform.position;
                item_code = 1;
            }
            else if (point >= 92)
            {
                drop_item = Instantiate(itemPrefab);
                drop_item.transform.position = this.transform.position;
                item_code = 2;
            }
            else
            {
                drop_item = null;
                no_item = true;
            }
            point = Random.Range(0, 100);
            if (point >= 50)
            {
                drop_item = Instantiate(itemPrefab);
                drop_item.transform.position = this.transform.position;
                item_code = 0;
            }
            if (no_item == false) drop_item.GetComponent<itemController>().item_code = item_code;
            Destroy(gameObject);
        }


    }

    private void OnTriggerEnter(Collider collision)
    {
        //ec = gameObject.GetComponent<EnemyController>();
        if (collision.gameObject.tag == "bullet")
        {
            this.gameObject.GetComponent<EnemyController>().monster_data.hp -= damage;
        }
    }
}