using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    void Start()
    {
        int health;
        health = 100 ;
        int damage = 20;
        Debug.Log("Health = " + health);
        health = health - damage;
        Debug.Log("Take Damage");
        Debug.Log("Health = "+health); 
    }

   
}
