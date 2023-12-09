using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    void Start()
    {
       



        float floatValue = 10.123f;
        int intValue = 5;
        floatValue = intValue;
      //  intValue = (int )floatValue;

        Debug.Log(" floatValue" + floatValue);
        //Debug.Log(" intValue" + intValue);

    }

   
}
