using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanLogic : MonoBehaviour
{
    public int age;

    // Start is called before the first frame update
    void Start()
    {
        bool statement1 = 1 == 1;
        print(statement1);

        bool statement2 = 5 > 5;
        print(statement2);

        bool statement3 = 500 != 300;
        print(statement3);

        // ---------------------------------------

        bool isAdult = age >= 18;
        print(isAdult);

        // ---------------------------------------
        
        bool complexStatement = -5 < 10 && 5 != 5;
        print(complexStatement);

        bool complexStatement2 = -5 < 10 || 5 != 5;
        print(complexStatement2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
