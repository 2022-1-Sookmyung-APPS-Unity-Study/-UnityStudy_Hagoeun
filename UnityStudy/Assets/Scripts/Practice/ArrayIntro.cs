using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayIntro : MonoBehaviour
{



    int SumArray(int[] arr)
    {

        int result = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i];
        }

        return result;
    }

    void PrintReverse(string[] arr) {

        for (int i = arr.Length - 1; i >= 0; i--) {
            print(arr[i]);

        }
    }

    int Max(int[] arr) {
        
        int max = arr[0];

        for (int i = 1; i < arr.Length; i++) {
            
            if (arr[i] > max) {
                max = arr[i];
            }
        
        }

        return max;

    }

    bool IsUniform(string[] arr) {
        
        bool result = true;

        for (int i = 1; i < arr.Length; i++) {

            if (arr[0] != arr[i]) {
                result = false;
            }
        
        }

        return result;
    
    } 

}
