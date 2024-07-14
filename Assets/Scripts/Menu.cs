using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string[] SceneToLoad; // название сцены каждого эпизода

    public void GoPlay(int x)
    {
        SceneManager.LoadScene(SceneToLoad[x-1]);
    }


}
