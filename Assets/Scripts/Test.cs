using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    void Start()
    {

        Debug.Log(10 / 2);
        Debug.Log(5 / 2);//��� �������� ������� ���� ���������� ���� �� ����� �������

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


        /*��������� � �������:
        �������� ���������� x � y �� ���������� 8 � 2 ��������������.
        �������� � ������� ���������� ��������� � �������: "x * y = [���������]", "x / y = [���������]".*/

        int x;
        x = 8;
        int y;
        y = 2;
        Debug.Log("x*y=" +( x * y));
        Debug.Log("x �������� ��  y=" + (x * y));
        Debug.Log("x/y=" +( x / y));
        Debug.Log("x ��������  y=" +( x / y));


    }

   
}
