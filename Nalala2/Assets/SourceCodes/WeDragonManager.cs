using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeDragonManager : MonoBehaviour
{
    // Start is called before the first frame update
<<<<<<< HEAD:Nalala2/Assets/SourceCodes/WeDragonManager.cs
    void Start()
    {
        
=======
    public int hp;
    GameObject go;
    void Start()
    {
        hp = 2; 
>>>>>>> 26656c70 (.gitattributes 넣고 재도전):NalalaYongari/Assets/SourceCodes/WeDragonManager.cs
    }

    // Update is called once per frame
    void Update()
    {
        
    }
<<<<<<< HEAD:Nalala2/Assets/SourceCodes/WeDragonManager.cs
=======
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "attack") // Attack of boss dragon
        {
            this.hp--;
            go = GameObject.Find("weDragon");
            Gameover1 go1 = go.GetComponent<Gameover1>();
            Destroy(other.gameObject);
            go1.pro_time += 3;
        }
        if (hp <= 0)
        {
            //Destroy(gameObject);
            Debug.Log("Game Over");
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
                    Application.Quit(); 
#endif
        }
    }
>>>>>>> 26656c70 (.gitattributes 넣고 재도전):NalalaYongari/Assets/SourceCodes/WeDragonManager.cs
}
