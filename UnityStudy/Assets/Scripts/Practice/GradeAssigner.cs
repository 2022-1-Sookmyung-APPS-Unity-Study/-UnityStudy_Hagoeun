using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradeAssigner : MonoBehaviour
{ 
    public float number1;
    public float number2;

    // --------------------
    [Range(0, 100)]

    public int score;


    // Start is called before the first frame update
    void Start()
    {
        if (number1 > number2)
        {
            print("Number 1 is bigger than number 2.");
        }
        else if (number2 > number1) {
            print("Number 2 is bigger than number 1.");
        }
        else if (number1 == number2) {
            print("Both numbers are the same.");
        }

        // ----------------

        if (score > 90) {
            print("You got an A.");
        } else if (score > 80) {
            print("You got a B.");
        } else if (score > 70) {
            print("You got a C.");
        } else if (score > 65) {
            print("You got a D.");
        } else {
            print("You got a E.");   
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
