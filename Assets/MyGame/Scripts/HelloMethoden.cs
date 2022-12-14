using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloMethoden : MonoBehaviour
{
    //Variable deklarieren
    private int startValue = 0;

    private int startValue3 = 0;

    private int startValue4 = 10;

    private int startValue5 = 20;

    void Start()
    {
        Debug.Log("Hallo Methoden!");

        Debug.Log("startValue: " + startValue);
        IncrementByOne();
        Debug.Log("afterValue: " + startValue);


        //add 3
        Debug.Log("startValue3: " + startValue3);
        IncrementByX(Random.Range(1,10));
        Debug.Log("afterValue3: " + startValue3);


        Debug.Log("startValue4: " + startValue4);
        DecrementByOne(startValue4);
        Debug.Log("afterValue4: " + startValue4);

        Debug.Log("startValue5: " + startValue5);
        startValue5 = DecrementByX(startValue5, 2);
        Debug.Log("afterValue5: " + startValue5);
    }
    
    private int DecrementByX(int start, int valToSub)
    {
        return start - valToSub;
    }

    private void DecrementByOne(int val)
    {
        val--;
        Debug.Log("val: " + val);
    }

    private void IncrementByX(int valToAdd)
    {
        startValue3 += valToAdd;
    }

    private void IncrementByOne()
    {
        startValue++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
