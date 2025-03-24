using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
public  class LoadMainda : MonoBehaviour
{
    public void LoadMaindas()
    {
        //Scene currentScene = SceneManager.GetActiveScene();
        GameObject[] pko = GameObject.FindGameObjectsWithTag("Kol");
        Staticclass.pkol = new Vector3[pko.Length];
        int i = 0;
        foreach (var item in pko)
        {
            Staticclass.pkol[i] = item.transform.position;             
                i++;
        }
        SceneManager.LoadScene(2);   
    } 
}
