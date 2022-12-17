using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using TMPro;

public class weDragonMove : MonoBehaviour
{
    Vector3 clickPoint; //���콺�� Ŭ���� ��ġ
    float computer_speed = 0.5f; //�����̴� �ӵ�
    private float Speed = 0.2f;
    private Vector2 nowPos, prePos;
    private Vector3 movePos;
    //private TextMeshProUGUI myCoin;
    public int get_coin = 0; //�� ���� ���� ���� ���� ��
    public int one_coin = 100; //���� 1���� 100��

    void Start()
    {
        //myCoin = GameObject.Find("coin").GetComponent<TextMeshProUGUI>();
        //myCoin.text = "[Get Coin]: " + get_coin.ToString();
        gameObject.transform.position = new Vector3(0, 7.5f, 8);
    }

    //void OnMouseDown()
    //{
    //    clickPoint = Input.mousePosition;
    //}

    //void OnMouseDrag()
    //{
    //    Vector3 differ = Input.mousePosition - clickPoint; //ó���� Ŭ���� ��ġ�� �巡���� ��ġ�� ����
    //    Vector3 pos = transform.position; //�ش���ġ�� �̵�
    //    if ((gameObject.transform.position.x <= -2 && differ.x <= 0) || (gameObject.transform.position.x >= 2 && differ.x >= 0)) return;
    //    pos.x += differ.x * Time.deltaTime * computer_speed; //�̵��Ÿ� �����ϱ� (�Ÿ�=�ӷ�*�ð� ����...)
    //    transform.position = pos; //transform.position�� ��ġ�� �����ϸ� �ش� ��ġ�� �̵��Ѵ�.
    //    clickPoint = Input.mousePosition;
    //}
    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                prePos = touch.position - touch.deltaPosition;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                nowPos = touch.position - touch.deltaPosition;
                movePos = (Vector3)(prePos - nowPos) * Time.deltaTime * Speed;
                if ((gameObject.transform.position.x <= -2 && movePos.x <= 0) || (gameObject.transform.position.x >= 2 && movePos.x >= 0)) return;
                gameObject.transform.Translate(-1*movePos.x, 0, 0);
                prePos = touch.position - touch.deltaPosition;
            }
        }
    }
}
