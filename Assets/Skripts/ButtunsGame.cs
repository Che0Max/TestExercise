using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtunsGame : MonoBehaviour
{
    public int PrewScene;
    public void NextScene()
    {
        SceneManager.LoadScene(PrewScene);
    }

    public void ExitTheGame()
    {
        Application.Quit();
    }
}
