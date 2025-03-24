using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Died : MonoBehaviour
{
    
   public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ExitMenu()
    {
        Coins.coins = 0;
        SceneManager.LoadScene(0);
    }
    
}
