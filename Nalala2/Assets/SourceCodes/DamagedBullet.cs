using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagedBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public int monster_code;
    public Monster monster_data;
    EnemyGenerator other;
    // Start is called before the first frame update
    void Start()
    {
        GameObject eg = GameObject.Find("EnemyGenerator");
        other = eg.GetComponent<EnemyGenerator>();
        monster_data = other.monster_data[monster_code].DeepCopy();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collision) // �浹�ϴ� ���� �۵�
    {
        if (collision.gameObject.tag == "enemy" )
        {
            Destroy(gameObject);
        }
    }
}