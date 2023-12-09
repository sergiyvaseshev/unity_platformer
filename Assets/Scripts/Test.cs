using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    void Start()
    {
        float distance = 108;// km
            float time = 143;//min

        float speed = distance / (time/60);

        Debug.Log("швидкість " + speed+"КМ/ГОД");

        decimal speedBIG = (decimal) distance / (decimal)(time / 60);

        Debug.Log("швидкість " + speedBIG + "КМ/ГОД");
    }

   
}
