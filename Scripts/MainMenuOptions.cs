using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour
{
    public void PlayScreen()
    {
        SceneManager.LoadScene("Play Options");
    }

    public void HelpAndAboutScreen()
    {
        SceneManager.LoadScene("Help and About");
    }

    public void HelpScreen()
    {
        SceneManager.LoadScene("Help Scene");
    }

    public void HelpScreen2()
    {
        SceneManager.LoadScene("Help Scene 2");
    }

    public void MainMenuScreen()
    {
        SceneManager.LoadScene("Main Screen");
    }
}
