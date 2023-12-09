using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    void Start()
    {

        Debug.Log(10 / 2);
        Debug.Log(5 / 2);//что получить дробное надо обозначить одно из чисел дробным

        Debug.Log(5 / 2f);
        Debug.Log(5 / 2.0);
        
        Debug.Log( "2.0"+"5");
        int apple;
        apple = 10;
        int tomato;
        tomato = 5;
        Debug.Log(apple+tomato);
        int Bag=apple+tomato;

        Debug.Log("Apple+Tomato ="+ apple + tomato);
        Debug.Log("Apple+Tomato ="+ (apple + tomato));
        Debug.Log("Apple+Tomato ="+ Bag);
        Debug.Log("Bag ="+ Bag);


        /*”множение и деление:
        —оздайте переменные x и y со значени€ми 8 и 2 соответственно.
        ¬ыведите в консоль результаты умножени€ и делени€: "x * y = [результат]", "x / y = [результат]".*/

        int x;
        x = 8;
        int y;
        y = 2;
        Debug.Log("x*y=" +( x * y));
        Debug.Log("x умножить на  y=" + (x * y));
        Debug.Log("x/y=" +( x / y));
        Debug.Log("x поделить  y=" +( x / y));


    }

   
}
