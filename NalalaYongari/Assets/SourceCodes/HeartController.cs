using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    // Start is called before the first frame update
    int hp;
    GameObject go;
    [SerializeField]
    private Material[] materials = new Material[3];
    private MeshRenderer mesh;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        go = GameObject.Find("weDragon");
        hp = go.GetComponent<WeDragonManager>().hp;
        mesh.material = materials[hp];
    }
}
