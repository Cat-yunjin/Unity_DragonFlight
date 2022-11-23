using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    Rigidbody rb;
<<<<<<< HEAD:Nalala2/Assets/SourceCodes/itemController.cs
=======
    public int item_code;
    [SerializeField]
    private Material[] materials = new Material[3];
    private MeshRenderer mesh;
>>>>>>> 26656c70 (.gitattributes 넣고 재도전):NalalaYongari/Assets/SourceCodes/itemController.cs
    //float power = 30f;
    // Start is called before the first frame update
    public int item_code;
    [SerializeField]
    private Material[] materials = new Material[3];
    private MeshRenderer mesh;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(Random.Range(-100, 100), 200, 0));

        mesh = GetComponent<MeshRenderer>();
        mesh.material = materials[item_code];
<<<<<<< HEAD:Nalala2/Assets/SourceCodes/itemController.cs
=======

>>>>>>> 26656c70 (.gitattributes 넣고 재도전):NalalaYongari/Assets/SourceCodes/itemController.cs
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<=-2 || transform.position.x >= 2)
        {
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
        }
        if (this.transform.position.y < -15)
        {
            Destroy(gameObject);
        }
         
    }
        private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "weDragon")
        {
            //ȿ�� �ߵ�
            switch (item_code)
            {
                case 0:
                    break;
                default:
                    break;
            }
            Destroy(gameObject);
        }
    }
}
