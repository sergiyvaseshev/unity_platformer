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
   
        // ������� ����
       health = health - damage;
       
      // ������
      // health -= damage;
        Debug.Log("Take Damage");
        Debug.Log("Health = "+health);
         int heal = 20;
        health = health + heal;
        Debug.Log("heal hero");
        Debug.Log("Health = " + health);

        int apple;
        apple = 5;

        int eatApple;
        eatApple = 2;
        apple = apple - eatApple;
    }

   
}
