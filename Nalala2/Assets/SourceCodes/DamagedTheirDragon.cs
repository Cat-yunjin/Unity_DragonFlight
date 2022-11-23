using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD:Nalala2/Assets/SourceCodes/DamagedTheirDragon.cs

public class DamagedTheirDragon : MonoBehaviour
{
=======
using System.IO;


public class DamagedTheirDragon : MonoBehaviour
{
    //public GameObject pro1Prefab;
    //public GameObject pro2Prefab;
>>>>>>> 26656c70 (.gitattributes 넣고 재도전):NalalaYongari/Assets/SourceCodes/DamagedTheirDragon.cs
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
<<<<<<< HEAD:Nalala2/Assets/SourceCodes/DamagedTheirDragon.cs
=======
            //if (point>=96)
            //{
            //    GameObject drop_item = Instantiate(pro1Prefab);
            //    drop_item.transform.position = this.transform.position;
            //}
            //else if (point>=92) 
            //{
            //    GameObject drop_item = Instantiate(pro2Prefab);
            //    drop_item.transform.position = this.transform.position;
            //}
            //else if (point >= 50)
            //{
            //    GameObject drop_item = Instantiate(itemPrefab);
            //    drop_item.transform.position = this.transform.position;
            //}
>>>>>>> 26656c70 (.gitattributes 넣고 재도전):NalalaYongari/Assets/SourceCodes/DamagedTheirDragon.cs
            GameObject drop_item;
            GameObject drop_coin;
            int item_code = -1;
            bool no_item = false;
            point = Random.Range(0, 100);
            if (point >= 96)
            {
<<<<<<< HEAD:Nalala2/Assets/SourceCodes/DamagedTheirDragon.cs
                drop_item = Instantiate(itemPrefab);
=======
                drop_item = Instantiate(itemPrefab); // ������ pro1
>>>>>>> 26656c70 (.gitattributes 넣고 재도전):NalalaYongari/Assets/SourceCodes/DamagedTheirDragon.cs
                drop_item.transform.position = this.transform.position;
                item_code = 1;
            }
            else if (point >= 92)
            {
<<<<<<< HEAD:Nalala2/Assets/SourceCodes/DamagedTheirDragon.cs
                drop_item = Instantiate(itemPrefab);
=======
                drop_item = Instantiate(itemPrefab); // ������ proj2
>>>>>>> 26656c70 (.gitattributes 넣고 재도전):NalalaYongari/Assets/SourceCodes/DamagedTheirDragon.cs
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
<<<<<<< HEAD:Nalala2/Assets/SourceCodes/DamagedTheirDragon.cs
            if (no_item == false) drop_item.GetComponent<itemController>().item_code = item_code;
            Destroy(gameObject);
        }


=======
            if(no_item ==false)
            drop_item.GetComponent<ItemController>().item_code = item_code;
            Destroy(gameObject);
        }
>>>>>>> 26656c70 (.gitattributes 넣고 재도전):NalalaYongari/Assets/SourceCodes/DamagedTheirDragon.cs
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