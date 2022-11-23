using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Gameover1 : MonoBehaviour
{
    //public static int pro_time = 0;
    public int pro_time = 0;
    static bool pro_bool = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(pro_red());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator pro_red()
    {
        if (pro_time > 0)
        {
            pro_time--;
            if (pro_time < 0)
            {
                pro_time = 0;
            }
        }
        yield return new WaitForSecondsRealtime(1.0f);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "item")
        {
            if (collision.gameObject.GetComponent<ItemController>().item_code == 1) // 프리팹 하나로 해결 가능하게 하려 함
            {
                pro_time += 3;
                Debug.Log("get item1");
            }
            if (collision.gameObject.GetComponent<ItemController>().item_code == 2)
            {
                pro_bool = true;
                Debug.Log("get item2");
            }
        }
        if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "meteor")
        {
            if (pro_time > 0)
            {
                Debug.Log("N-sec protect");
            }

            else if (pro_bool == true)
            {
                pro_bool = false;
                Debug.Log("1-time protect");
                Destroy(collision.gameObject);
                pro_time += 1;
            }
            else
            {
                Destroy(gameObject);
                Debug.Log("Game Over");
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#else
                    Application.Quit(); 
#endif
            }
            //string fullpth = "Assets/totalMoney";
            //StreamWriter sw;

            //sw = new StreamWriter(fullpth + ".txt");

            //sw.WriteLine(GameObject.Find("weDragon").GetComponent<weDragonMove>().get_coin);

            //sw.Flush();
            //sw.Close();
        }
    }
}
