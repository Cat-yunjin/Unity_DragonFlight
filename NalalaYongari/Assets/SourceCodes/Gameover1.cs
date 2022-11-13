using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Gameover1 : MonoBehaviour
{
    static int pro_time = 0;
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
        if (collision.gameObject.tag == "pro1")
        {
            pro_time += 3;
        }
        if (collision.gameObject.tag == "pro2")
        {
            pro_bool = true;
        }
        if (collision.gameObject.tag == "enemy")
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
            string fullpth = "Assets/totalMoney";
            StreamWriter sw;

            sw = new StreamWriter(fullpth + ".txt");

            sw.WriteLine(GameObject.Find("weDragon").GetComponent<weDragonMove>().get_coin);

            sw.Flush();
            sw.Close();


        }
    }
}
