using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
public class DamagedWeDragon : MonoBehaviour
{
    // Start is called before the first frame update
    int one_coin;
    public int get_coin;
    ItemController ic;
    private TextMeshProUGUI myCoin;
    void Start()
    {
        get_coin = 0;
        one_coin = 100;
        myCoin = GameObject.Find("coin").GetComponent<TextMeshProUGUI>();
        myCoin.text = "[Get Coin] : " + get_coin.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        SetCountText();
    }

    private void OnTriggerEnter(Collider collision) // 충돌하는 순간 작동
    {
        if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "meteor") // 우리드래곤이 운석하고 부딪히면
        {
            Debug.Log("우리 드래곤이 적 또는 운석하고 부딪힘");
            //Destroy(gameObject);
            //Debug.Log("Game Over");
            //#if UNITY_EDITOR
            //        UnityEditor.EditorApplication.isPlaying = false;
            //#else
            //Application.Quit();
            //#endif
        }
        else if (collision.gameObject.tag == "item")
        {
            if (collision.GetComponent<ItemController>().item_code == 0)
            {
                get_coin += one_coin;
                Debug.Log(get_coin);
                string fullpth = "Assets/totalMoney";
                StreamWriter sw;
                sw = new StreamWriter(fullpth + ".txt");
                sw.WriteLine(get_coin);
                sw.Flush();
                sw.Close();
            }
        }
    }
    void SetCountText()
    {
        myCoin.text = "[Get Coin] : " + get_coin.ToString();
    }    
}