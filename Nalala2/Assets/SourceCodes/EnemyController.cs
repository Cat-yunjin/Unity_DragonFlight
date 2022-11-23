using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int monster_code;
    public Monster monster_data;
    EnemyGenerator other;
    [SerializeField]
    private Material[] materials = new Material[2];
    private MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
        GameObject eg = GameObject.Find("EnemyGenerator");
        other = eg.GetComponent<EnemyGenerator>();
        monster_data = other.monster_data[monster_code].DeepCopy();
        mesh = GetComponent<MeshRenderer>();
        mesh.material = materials[monster_code];
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.1f, 0);

        if (transform.position.y < -1.0f)
        {
            Destroy(gameObject);
        }
    }
}
