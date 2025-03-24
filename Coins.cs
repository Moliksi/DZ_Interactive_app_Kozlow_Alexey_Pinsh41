using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Coins : MonoBehaviour
{
    public Text coinsText;
    public static int coins;
    public static int diedint;
    // Update is called once per frame
    void Update()
    {
        coinsText.text = coins.ToString();
    }
}
