using UnityEngine;
using System.Collections;
public class Player_Collision : MonoBehaviour
{
    public Player_Movement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {

        if(collisionInfo.collider.tag == "Obstacle")
        {
             GetComponent<Player_Movement>().enabled = false;
        }
    }

}
