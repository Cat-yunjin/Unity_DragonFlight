using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
<<<<<<< HEAD:Nalala2/Assets/SourceCodes/DamagedWeDragon.cs
=======

>>>>>>> 26656c70 (.gitattributes 넣고 재도전):NalalaYongari/Assets/SourceCodes/DamagedWeDragon.cs
public class DamagedWeDragon : MonoBehaviour
{
    // Start is called before the first frame update
    int one_coin;
    public int get_coin;
<<<<<<< HEAD:Nalala2/Assets/SourceCodes/DamagedWeDragon.cs
    itemController ic;
=======
    ItemController ic;
>>>>>>> 26656c70 (.gitattributes 넣고 재도전):NalalaYongari/Assets/SourceCodes/DamagedWeDragon.cs
    private TextMeshProUGUI myCoin;
    void Start()
    {
        get_coin = 0;
        one_coin = 100;
        myCoin = GameObject.Find("coin").GetComponent<TextMeshProUGUI>();
<<<<<<< HEAD:Nalala2/Assets/SourceCodes/DamagedWeDragon.cs
        myCoin.text = "[Get Coin] : " + get_coin.ToString();
=======
        myCoin.text = "[Get Coin]: " + get_coin.ToString();
>>>>>>> 26656c70 (.gitattributes 넣고 재도전):NalalaYongari/Assets/SourceCodes/DamagedWeDragon.cs
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
<<<<<<< HEAD:Nalala2/Assets/SourceCodes/DamagedWeDragon.cs
            //Debug.Log("�츮 �巡���� �� �Ǵ� ��ϰ� �ε���");
            Destroy(gameObject);
            Debug.Log("Game Over");
            //#if UNITY_EDITOR
            //        UnityEditor.EditorApplication.isPlaying = false;
            //#else
            //Application.Quit();
            //#endif
        }
        else if (collision.gameObject.tag == "item")
        {
            if (collision.GetComponent<itemController>().item_code == 0)
=======
            Debug.Log("�츮 �巡���� �� �Ǵ� ��ϰ� �ε���");
        }
        else if (collision.gameObject.tag == "item")
        {
            if (collision.GetComponent<ItemController>().item_code == 0)
>>>>>>> 26656c70 (.gitattributes 넣고 재도전):NalalaYongari/Assets/SourceCodes/DamagedWeDragon.cs
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
<<<<<<< HEAD:Nalala2/Assets/SourceCodes/DamagedWeDragon.cs

    void SetCountText()
    {
        myCoin.text = "[Get Coin] : " + get_coin.ToString();
    }    
=======
    private void OnTriggerExit(Collider collision) // �浹�� ���� ���� �۵�
    {

    }
    private void OnTriggerStay(Collider collision) // �浹�ϴ� ���� �۵�
    {

    }
    void SetCountText()
    {
        myCoin.text = "[Get Coin]: " + get_coin.ToString();
    }

>>>>>>> 26656c70 (.gitattributes 넣고 재도전):NalalaYongari/Assets/SourceCodes/DamagedWeDragon.cs
}