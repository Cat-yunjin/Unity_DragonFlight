using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster
{
    int monster_type;
    public int hp;
    public Monster() { }
    public int num_of_item = 3;
    public Monster(int _monster_type, int _hp)
    {
        monster_type = _monster_type;
        hp = _hp;
    }
    public Monster DeepCopy()
    {
        Monster newCopy = new Monster();
        newCopy.monster_type = this.monster_type;
        newCopy.hp = this.hp;
        return newCopy;
    }
    //int look;
}

public class EnemyGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public Monster[] monster_data = new Monster[2];
    public GameObject enemyPrefab;
    public GameObject BossPrefab;
    Vector3 startPos;
    float boss_span = 10f;
    public static bool boss_chk = false;
    float span = 1f;
    float delta = 0;
    float[] x_pos = new float[] { -2.0f, -1.0f, 0, 1.0f, 2.0f };
    // Update is called once per frame
    void Start()
    {
        monster_data[0] = new Monster(0, 100);
        monster_data[1] = new Monster(1, 200);
    }
    void Update()
    {
        //GameObject go = Instantiate(arrow)
        if (boss_chk == false) this.delta += Time.deltaTime;
        if (this.delta > this.span && boss_span >= 0)
        {
            this.boss_span -= 1f;
            this.delta = 0;
            int normal_monster_code = 0;
            int strong_monster_code = 1;
            int strongest_monster_loc = Random.Range(0, 5);
            int monster_code;
            for (int i = 0; i < 5; i++)
            {
                GameObject monster;
                if (i == strongest_monster_loc) monster_code = strong_monster_code;
                else monster_code = normal_monster_code;
                monster = Instantiate(enemyPrefab);
                monster.GetComponent<EnemyController>().monster_code = monster_code;
                monster.transform.position = new Vector3(x_pos[i], 15, 8);
            }
        }
        else if (this.delta > this.span && boss_span <= 0)
        {
            boss_chk = true;
            this.delta = 0;
            this.boss_span = 20f;
            GameObject boss;
            boss = Instantiate(BossPrefab);
            boss.transform.position = new Vector3(0, 13, 8);
        }
    }
}
