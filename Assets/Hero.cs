using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    private float dir;
    public float speed;
    // Start is called before the first frame update
    public void SetDir(int value)
    {
        dir = value;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isMove = dir != 0;
        if (isMove)
        {
            var delta=dir*speed;
            transform.position = new Vector3(transform.position.x + delta,transform.position.y,transform.position.z);
        }
    }
}
