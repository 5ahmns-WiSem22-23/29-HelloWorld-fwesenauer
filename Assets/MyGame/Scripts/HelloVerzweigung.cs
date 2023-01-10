
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloVerzweigung : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 10;
        int b = 20;
        int c = 30;
        int x = 4;
        int y = 8;

        // Einfache if-Anweisung
        if (a > b)
        {
            Debug.Log("a ist größer als b");
        }
        else
        {
            Debug.Log("a ist nicht größer als b");
        }

        // If-Anweisung mit else if
        if (a > b)
        {
            Debug.Log("a ist größer als b");
        }
        else if (a < b)
        {
            Debug.Log("a ist kleiner als b");
        }
        else
        {
            Debug.Log("a ist gleich b");
        }

        // Switch
        switch (x)
        {
            case 1:
                Debug.Log("x is 1");
                break;
            case 2:
                Debug.Log("x is 2");
                break;
            default:
                Debug.Log("x is neither 1 nor 2");
                break;
        }
        //if mit Return
        int GetValue(int x)
        {
            if (x > 0)
            {
                return x;
            }

            return 0;
        }
        // Verschachtelt
        if (x > 0)
        {
            if (y > 0)
            {
                Debug.Log("x and y are both positive");
            }
            else
            {
                Debug.Log("x is positive and y is non-positive");
            }
        }
        else
        {
            if (y > 0)
            {
                 Debug.Log("x is non-positive and y is positive");
            }
            else
            {
                Debug.Log("x and y are both non-positive");
            }
        }
        // temary
        int max = x > y ? x : y;
        Debug.Log(max);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
