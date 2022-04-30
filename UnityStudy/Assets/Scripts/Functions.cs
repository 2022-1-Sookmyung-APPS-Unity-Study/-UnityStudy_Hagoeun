using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{

    bool IsEven(int number) {
        
        if (number % 2 == 0)
        {
            return true;
        }
        else {
            return false;
        }
    }

    int WhatIsBigger(int number1, int number2) {
        
        if (number1 > number2)
        {
            return number1;
        }
        else {
            return number2;
        }
    }

    void Repeat(string text, int numberOfRepeats) {

        for (int i = 0; i < numberOfRepeats; i++) {
            print(text);
        }
    }

    int Factorial(int number) {
        
        int result = 1;

        for (int i = 1; i <= number; i++) {
            result *= 1;
        }

        return result;
    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
