using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class StopMove : MonoBehaviour
{
    public static int kols = 1;   
    public void Stop()
    {       
        GameObject p = GameObject.FindWithTag("Player");
        p.GetComponent<SvobodaCamera>().enabled=false;
    }
    public void StartKol()
    {
        GameObject[] pkol = GameObject.FindGameObjectsWithTag("Kol");
        pkol[kols].GetComponent<SvobodaCamera>().enabled = true;
    }
    public void StartPlayer()
    {       
        GameObject p = GameObject.FindWithTag("Player");
        p.GetComponent<SvobodaCamera>().enabled = true;
    }
    public void StopKol()
    {
        GameObject[] pkol = GameObject.FindGameObjectsWithTag("Kol");
        pkol[kols].GetComponent<SvobodaCamera>().enabled =false;
        kols++;
    }
    
}
