using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public static int coinTotal = 0;
    public static float timeTotal = 0;
    void Update()
    {
        
        timeTotal += Time.deltaTime;

        if (gameObject.name == "Coins")
        {
            transform.Rotate (0, 0, 2);
        }
        
    }
}
