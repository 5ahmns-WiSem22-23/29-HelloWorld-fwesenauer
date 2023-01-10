using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloOperatoren : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Zuweisungs Operatoren
        int a = 10;
        int b = 20;

        // Arithmetische Operatoren
        Debug.Log("a + b = " + (a + b));
        Debug.Log("a - b = " + (a - b));
        Debug.Log("a * b = " + (a * b));
        Debug.Log("a / b = " + (a / b));
        Debug.Log("a % b = " + (a % b));

        // Gleichheits Operatoren
        Debug.Log("a == b: " + (a == b));
        Debug.Log("a != b: " + (a != b));

        // Vergleichs Operatoren
        Debug.Log("a > b: " + (a > b));
        Debug.Log("a < b: " + (a < b));
        Debug.Log("a >= b: " + (a >= b));
        Debug.Log("a <= b: " + (a <= b));

        // Logische Operatoren
        bool c = true;
        bool d = false;

        Debug.Log("c && d: " + (c && d));
        Debug.Log("c || d: " + (c || d));
        Debug.Log("!c: " + (!c));
    }


    // Update is called once per framef cecdecd
    void Update()
    {
        
    }
}
