using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public int nextScene;
    public static int  mainScene = 0;
    public static int dieScene = 2;
    //[SerializeField] private int _numberPreviousScene;

    public void NextScene()
    {
        SceneManager.LoadScene(nextScene);
    }

    public void MenuScene()
    {
        SceneManager.LoadScene(mainScene);
    }

    public void ExitTheGame()
    {
        Application.Quit();
    }

}
