using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    void Update()
    {
        GetComponent<TextMesh>().text = "Coins : " +Coin.coinTotal;
    
    if(gameObject.name == "Time")
    {
        GetComponent<TextMesh>().text = "Time : " +Coin.timeTotal;
    }

}
}
