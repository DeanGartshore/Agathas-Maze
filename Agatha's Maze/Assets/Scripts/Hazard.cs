using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    void OnTriggerEnter(Collider objectWeCollidedWith)
    {
        
        

        PlayerHealth player = objectWeCollidedWith.GetComponent<PlayerHealth>();
       
        
        if (player != null)
        {

            player.Kill();

        }

    }

       



}
