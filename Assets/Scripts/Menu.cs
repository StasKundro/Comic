using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string[] SceneToLoad; // �������� ����� ������� �������

    public void GoPlay(int x)
    {
        SceneManager.LoadScene(SceneToLoad[x-1]);
    }


}
