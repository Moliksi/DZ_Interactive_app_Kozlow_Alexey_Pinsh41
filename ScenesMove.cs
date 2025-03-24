using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScenesMove : MonoBehaviour
{
    public GameObject kol;
    private void Awake()
    {
        if (Staticclass.pkol != null)
        {
            int i = 1;
            foreach (var item in Staticclass.pkol)
            {
                Instantiate(kol,Staticclass.pkol[i],Quaternion.identity);
                i++;
            }
            Staticclass.pkol = null;
        }
    }
}
