using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScripts : MonoBehaviour
{
    public void StartNewGame()
    {
        OpenLevel(1);
    }

    public void OpenLevel(int number)
    {
        switch (number)
        {
            case 1:
                SceneManager.LoadScene("SampleScene");
                break;
            case 2:
                SceneManager.LoadScene("SampleScene 1");
                break;
            case 3:
                SceneManager.LoadScene("SampleScene 2");
                break;
            case 4:
                SceneManager.LoadScene("SampleScene 3");
                break;
            case 5:
                SceneManager.LoadScene("SampleScene 4");
                break;
            case 6:
                SceneManager.LoadScene("SampleScene 5");
                break;
            case 7:
                SceneManager.LoadScene("SampleScene 6");
                break;
            case 8:
                SceneManager.LoadScene("SampleScene 7");
                break;
            case 9:
                SceneManager.LoadScene("SampleScene 8");
                break;
            case 10:
                SceneManager.LoadScene("SampleScene 9");
                break;
            case 11:
                SceneManager.LoadScene("SampleScene 10");
                break;
            case 12:
                SceneManager.LoadScene("SampleScene 11");
                break;
            default:
                SceneManager.LoadScene("SampleScene");
                break;
        }
    }
}
