using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOptions : MonoBehaviour
{
    public void Play2Player()
    {
        SceneManager.LoadScene("Main");
    }

    public void Play3Player()
    {
        SceneManager.LoadScene("3 Player");
    }

    public void TagTeam()
    {
        SceneManager.LoadScene("2 Vs 2");
    }
}
