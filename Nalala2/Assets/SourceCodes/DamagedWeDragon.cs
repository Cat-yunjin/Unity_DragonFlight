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

    private void OnTriggerEnter(Collider collision) // �浹�ϴ� ���� �۵�
    {
        if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "meteor") // �츮�巡���� ��ϰ� �ε�����
        {
            Debug.Log("�츮 �巡���� �� �Ǵ� ��ϰ� �ε���");
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