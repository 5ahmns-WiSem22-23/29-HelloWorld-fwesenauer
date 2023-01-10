using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloIf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 10;
        int b = 20;
        int c = 30;

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

        // If-Anweisung mit mehreren Bedingungen
        if (a > b && a > c)
        {
            Debug.Log("a ist größer als b und c");
        }
        else if (b > a && b > c)
        {
            Debug.Log("b ist größer als a und c");
        }
        else
        {
            Debug.Log("c ist größer als a und b");
        }
    }
}
