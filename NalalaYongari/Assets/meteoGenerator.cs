using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteoGenerator : MonoBehaviour
{

    public GameObject meteoPrefab;
    float span = 8.0f; // ����� 8�ʸ��� ����, ���� �� ���� ����� ��
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.span)
        {
            this.delta = 0;

            GameObject meteo = Instantiate(meteoPrefab);

            //int px = Random.Range(-2, 2);
            meteo.transform.position = new Vector3(GameObject.Find("weDragon").transform.position.x, 
                GameObject.Find("warnline").transform.position.y, 8);
        }
    }
}
