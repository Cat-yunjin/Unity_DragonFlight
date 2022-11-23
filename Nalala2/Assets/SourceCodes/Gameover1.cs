using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.SceneManagement; // ÇÊ¿ä

public class Gameover1 : MonoBehaviour
{
    public int pro_time = 0;
    static bool pro_bool = false;

    public static float overtime = 0f;
    float sec_count = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(pro_red());
    }

    // Update is called once per frame
    void Update()
    {
        overtime += Time.deltaTime;
        if (pro_time > 0)
        {
            sec_count += Time.deltaTime;
            if (sec_count >= 1)
            {
                sec_count = 0f;
                pro_time--;
            }
        }
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
            if (collision.gameObject.GetComponent<ItemController>().item_code == 1)
            {
                pro_time += 3;
                Debug.Log("get item1(3-sec pro) ");
            }
            if (collision.gameObject.GetComponent<ItemController>().item_code == 2)
            {
                pro_bool = true;
                Debug.Log("get item2(1 time pro)");
            }
        }
        if(collision.gameObject.tag=="enemy" || collision.gameObject.tag == "meteor")
        {
            if (pro_time > 0)
            {
                Debug.Log("N-sec protect");
            }
            else if(pro_bool == true)
            {
                pro_bool = false;
                Debug.Log("1-time protect");
                Destroy(collision.gameObject);
                //pro_time += 1;
            }
            else
            {
                Destroy(gameObject);
                Debug.Log("Game Over");

                SceneManager.LoadScene("GameOverScene");
//#if UNITY_EDITOR
//                UnityEditor.EditorApplication.isPlaying = false;
//#else
//                Application.Quit();
//#endif
            }
        }
//        if (collision.gameObject.tag == "pro1")
//        {
//            pro_time += 3;
//        }
//        if (collision.gameObject.tag == "pro2")
//        {
//            pro_bool = true;
//        }
//        if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "meteor")
//        {
//            if (pro_time > 0)
//            {
//                Debug.Log("N-sec protect");
//            }

//            else if (pro_bool == true)
//            {
//                pro_bool = false;
//                Debug.Log("1-time protect");
//                Destroy(collision.gameObject);
//            }
//            else
//            {
//                Destroy(gameObject);
//                Debug.Log("Game Over");
//#if UNITY_EDITOR
//                    UnityEditor.EditorApplication.isPlaying = false;
//#else
//                    Application.Quit(); 
//#endif
//            }

//            string fullpth = "Assets/totalMoney";
//            StreamWriter sw;

//            sw = new StreamWriter(fullpth + ".txt");

//            sw.WriteLine(GameObject.Find("weDragon").GetComponent<weDragonMove>().get_coin);

//            sw.Flush();
//            sw.Close();

//            SceneManager.LoadScene(2);
//        }

        
    }

}
