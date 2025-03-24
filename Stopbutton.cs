using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stopbutton : MonoBehaviour
{
    public GameObject button;
   public void stopbutton()
    {
        if (StopMove.kols > 10)
            button.SetActive(false);
    }
}
