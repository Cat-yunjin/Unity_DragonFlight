using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagedBullet : MonoBehaviour
{
<<<<<<< HEAD:Nalala2/Assets/SourceCodes/DamagedBullet.cs
<<<<<<<< HEAD:Nalala2/Assets/SourceCodes/DamagedBullet.cs
=======
>>>>>>> 26656c70 (.gitattributes 넣고 재도전):NalalaYongari/Assets/SourceCodes/DamagedBullet.cs
    // Start is called before the first frame update
    void Start()
    {

<<<<<<< HEAD:Nalala2/Assets/SourceCodes/DamagedBullet.cs
========
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
>>>>>>>> 26656c70 (.gitattributes 넣고 재도전):NalalaYongari/Assets/SourceCodes/EnemyController.cs
=======
>>>>>>> 26656c70 (.gitattributes 넣고 재도전):NalalaYongari/Assets/SourceCodes/DamagedBullet.cs
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collision) // �浹�ϴ� ���� �۵�
    {
        if (collision.gameObject.tag == "enemy" )
        {
            Destroy(gameObject);
        }
    }
<<<<<<< HEAD:Nalala2/Assets/SourceCodes/DamagedBullet.cs
    
=======
    private void OnTriggerExit(Collider collision) // �浹�� ���� ���� �۵�
    {

    }
    private void OnTriggerStay(Collider collision) // �浹�ϴ� ���� �۵�
    {

    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "meteo")
        {
            Destroy(gameObject);
        }
    }
    */
>>>>>>> 26656c70 (.gitattributes 넣고 재도전):NalalaYongari/Assets/SourceCodes/DamagedBullet.cs
}