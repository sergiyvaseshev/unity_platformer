using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    void Start()
    {

        int a = 5;
        int b = 10;
        int c = 10;


        /*bool result = a > b; //False
        Debug.Log("  a > b=" + result);

         result = a < b; //True
        Debug.Log("  a < b=" + result);

        result = a ==b; //False
        Debug.Log("  a == b=" + result);

        result = a != b; //True
        Debug.Log("  a != b=" + result);*/

        bool result = a>=b; //False
        Debug.Log("  a >= b=" + result);

         result = b >= c; //True
        Debug.Log("  b>= c=" + result);

        result = a <= b; //True
        Debug.Log("  a<= b=" + result);

    }


   
}
