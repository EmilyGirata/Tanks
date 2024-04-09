using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void RestartPlay2PlayerScene()
    {
        SceneManager.LoadScene("Main");
    }

    public void RestartPlay3PlayerScene()
    {
        SceneManager.LoadScene("3 Player");
    }

    public void RestartTagTeamScene()
    {
        SceneManager.LoadScene("2 Vs 2");
    }
}
