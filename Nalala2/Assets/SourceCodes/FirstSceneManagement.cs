using UnityEngine;

using UnityEngine.SceneManagement;



public class ForceStart : MonoBehaviour
{

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]

    static void FirstLoad()

    {

        if (SceneManager.GetActiveScene().name.CompareTo("OpeningScene") != 0)

        {

            SceneManager.LoadScene("OpeningScene");

        }

    }

}
