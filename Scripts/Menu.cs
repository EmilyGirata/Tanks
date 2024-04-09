using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play2PlayerMenuScene()
    {
        SceneManager.LoadScene("Main 2 Menu");
    }

    public void Play3PlayerMenuScene()
    {
        SceneManager.LoadScene("3 Player Menu");
    }

    public void TagTeamMenuScene()
    {
        SceneManager.LoadScene("2 Vs 2 Menu");
    }
}
