using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class bulletGenerator : MonoBehaviour
{
    float delta = 0f;
<<<<<<< HEAD:NalalaYongari/Assets/SourceCodes/bulletGenerator.cs
    float span = 0.10f;
=======
    float span = 1.0f; // 0.3
>>>>>>> origin/yunjin:NalalaYongari/Assets/bulletGenerator.cs

    public GameObject bulletPrefab;
    //float speed = 3.0f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.transform.position = new Vector3(GameObject.Find("weDragon").transform.position.x, 7.5f, 8.0f);
            
        }
    }
}
