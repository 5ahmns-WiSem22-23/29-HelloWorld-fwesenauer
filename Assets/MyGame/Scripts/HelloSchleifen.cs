using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloSchleifen : MonoBehaviour
{
    string[,] alphabetArray = new string[3, 4];
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                alphabetArray[i, j] = ((char)('A' + counter)).ToString();
                Debug.Log("Row: " + i + " Column: " + j + " Letter: " + alphabetArray[i, j]);
                counter++;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
