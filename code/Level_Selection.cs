using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level_Selection : MonoBehaviour
{
    public void Playlevel1()
    {
        SceneManager.LoadScene(4);
    }
    public void Playlevel2()
    {
        SceneManager.LoadScene(5);
    }
    public void Playlevel3()
    {
        SceneManager.LoadScene(6);
    }
}


