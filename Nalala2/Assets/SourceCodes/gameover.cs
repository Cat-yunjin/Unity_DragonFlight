using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

[AddComponentMenu("UI/gameover", 11)]

public class gameover : MonoBehaviour
{
    public TextMeshProUGUI gold_txt;
    public TextMeshProUGUI score_txt;

    float time = 0;
    private void Start()
    {
        string path = "Assets/totalmoney";
        string line;
        StreamReader sr;

        sr = new StreamReader(path + ".txt");

        line = sr.ReadLine();
        gold_txt.text = line;

        sr.Close();

        score_txt.text = Gameover1.overtime.ToString("F2");
    }
}
