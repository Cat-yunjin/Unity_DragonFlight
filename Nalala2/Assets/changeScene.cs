using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public void changeSceneBtn()
    {
        SceneManager.LoadScene("BattleScene");
    }

    public void changeSceneBtn2()
    {
        SceneManager.LoadScene("");// ���⿡ ���� �̸� �ְ� �ϸ� �� ��
    }
}
