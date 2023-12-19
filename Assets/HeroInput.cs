using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInput : MonoBehaviour
{
    public Hero hero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            hero.SetDir(-1);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            hero.SetDir(1);
        }
        else
        {
            hero.SetDir(0);
        }
    }
}
