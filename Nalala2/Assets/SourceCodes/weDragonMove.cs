using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using TMPro;

public class weDragonMove : MonoBehaviour
{
    Vector3 clickPoint; //¸¶¿ì½º¸¦ Å¬¸¯ÇÑ À§Ä¡
    float Speed = 0.5f; //¿òÁ÷ÀÌ´Â ¼Óµµ

    //private TextMeshProUGUI myCoin;
    public int get_coin = 0; //ÇÑ °ÔÀÓ µµÁß ¾òÀº ÄÚÀÎ °ª
    public int one_coin = 100; //ÄÚÀÎ 1°³´ç 100¿ø

    void Start()
    {
<<<<<<< HEAD:Nalala2/Assets/SourceCodes/weDragonMove.cs
        myCoin = GameObject.Find("coin").GetComponent<TextMeshProUGUI>();
        myCoin.text = "[Get Coin]: " + get_coin.ToString();
=======
        //myCoin = GameObject.Find("coin").GetComponent<TextMeshProUGUI>();
        //myCoin.text = "[Get Coin]: " + get_coin.ToString();
>>>>>>> 26656c70 (.gitattributes ë„£ê³  ì¬ë„ì „):NalalaYongari/Assets/SourceCodes/weDragonMove.cs
        gameObject.transform.position = new Vector3(0, 7, 8);
    }

    void OnMouseDown()
    {
        clickPoint = Input.mousePosition;
    }

    void OnMouseDrag()
    {
        Vector3 differ = Input.mousePosition - clickPoint; //Ã³À½¿¡ Å¬¸¯ÇÑ À§Ä¡¿Í µå·¡±×ÇÑ À§Ä¡ÀÇ Â÷ÀÌ
        Vector3 pos = transform.position; //ÇØ´çÀ§Ä¡·Î ÀÌµ¿
        pos.x += differ.x * Time.deltaTime * Speed; //ÀÌµ¿°Å¸® º¸Á¤ÇÏ±â (°Å¸®=¼Ó·Â*½Ã°£ ´À³¦...)
        transform.position = pos; //transform.position¿¡ À§Ä¡¸¦ ´ëÀÔÇÏ¸é ÇØ´ç À§Ä¡·Î ÀÌµ¿ÇÑ´Ù.
        clickPoint = Input.mousePosition;
    }

    private void OnTriggerEnter(Collider col)
    {

        //if (col.gameObject.tag == "Coin")
        //{
        //    get_coin += one_coin;
        //    Debug.Log(get_coin);
        //}

        //if (col.gameObject.tag == "gem")
        //{
        //    get_coin += one_coin * 10;
        //    Debug.Log(get_coin);
        //}

    }

    //void SetCountText()
    //{
    //    myCoin.text = "[Get Coin]: " + get_coin.ToString();
    //}

    //void Update()
    //{
    //    SetCountText();
    //}
}