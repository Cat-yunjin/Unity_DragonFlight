using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fixed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetResolution(); 
    }
    public void SetResolution()
    {
        int setWidth = 720;
        int setHeight = 1280;
        Screen.SetResolution(setWidth, setHeight, true);
    }
}
