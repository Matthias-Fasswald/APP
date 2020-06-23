using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Player_Movement : MonoBehaviour
{

    public Rigidbody Player;
    
    public float forward = 500f;
    public float sideway = 500f;
    // Update is called once per frame
     void Update()
    {
        // Moving Player constantly forward
        Player.AddForce(0, 0, forward * Time.deltaTime);
        // Moves Player right / slows down / left
        if(Input.GetKey("d"))
        {
            Player.AddForce(sideway * Time.deltaTime, 0, 0); 
        }
        if(Input.GetKey("s"))
        {
            Player.AddForce(0, 0, -forward * Time.deltaTime); 
        }
        if(Input.GetKey("a"))
        {
            Player.AddForce(-sideway * Time.deltaTime, 0, 0); 
        }
 
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.name == "exit")
        {
            SceneManager.LoadScene("CompleteScene");
        }

        if(other.gameObject.name == "Coins")
        {
            Destroy(other.gameObject);   
            Coin.coinTotal += 1;
        }
    }

    

}
